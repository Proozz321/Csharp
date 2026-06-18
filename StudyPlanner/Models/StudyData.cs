using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudyPlanner.Models;

public static class StudyData
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new JsonStringEnumConverter() }
    };

    private static List<Phase>? _cachedPhases;
    private static readonly object _lock = new();

    public static List<Phase> GetPhases()
    {
        if (_cachedPhases is not null)
            return _cachedPhases;

        lock (_lock)
        {
            if (_cachedPhases is not null)
                return _cachedPhases;

            // Assumes the JSON file is in the output directory (bin)
            // For web apps, use wwwroot or content root
            var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "studyplan.json");
            
            if (!File.Exists(jsonPath))
            {
                // Fallback for development: try relative path
                jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "studyplan.json");
            }

            var json = File.ReadAllText(jsonPath);
            
            var phases = JsonSerializer.Deserialize<List<Phase>>(json, JsonOptions)
                         ?? new List<Phase>();

            // Calculate IsCurrent and IsDone based on Week Start/End dates
            var today = DateTime.Today;
            int uniqueId = 1;

            foreach (var phase in phases)
            {
                foreach (var week in phase.Weeks)
                {
                    // Dates are stored as ISO strings (yyyy-MM-dd)
                    if (DateTime.TryParse(week.StartDate, out var start) &&
                        DateTime.TryParse(week.EndDate, out var end))
                    {
                        week.IsCurrent = today >= start && today <= end;
                        week.IsDone = today > end;
                    }
                    else
                    {
                        // Fallback: if dates are missing or invalid, mark as false
                        week.IsCurrent = false;
                        week.IsDone = false;
                    }

                    // Assign UniqueId to each day
                    foreach (var day in week.Days)
                    {
                        day.UniqueId = uniqueId++;
                    }
                }
            }

            _cachedPhases = phases;
            return _cachedPhases;
        }
    }

    // Optional: method to reload if the JSON file changes (for hot-reload scenarios)
    public static void InvalidateCache()
    {
        lock (_lock)
        {
            _cachedPhases = null;
        }
    }
}