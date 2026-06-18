using System.Text.Json;

namespace StudyPlanner.Models;

public static class SaveData
{
    private static readonly string SavePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        ".studyplanner.json");

    public static HashSet<int> LoadCompleted()
    {
        if (!File.Exists(SavePath)) return new();
        var json = File.ReadAllText(SavePath);
        return JsonSerializer.Deserialize<HashSet<int>>(json) ?? new();
    }

    public static void SaveCompleted(HashSet<int> completedDays)
    {
        var json = JsonSerializer.Serialize(completedDays);
        File.WriteAllText(SavePath, json);
    }
}