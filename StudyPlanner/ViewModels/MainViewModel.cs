using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudyPlanner.Models;

namespace StudyPlanner.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private Phase? _selectedPhase;

    [ObservableProperty]
    private Week? _selectedWeek;

    [ObservableProperty]
    private int _progressPercent;

    [ObservableProperty]
    private string _phaseAccentColor = "#7c7cff";

    [ObservableProperty]
    private double _progressBarWidth;

    public List<Phase> Phases { get; } = StudyData.GetPhases();

    private readonly HashSet<int> _completedDays;

    private List<DayTask> AllDays => Phases
        .SelectMany(p => p.Weeks)
        .SelectMany(w => w.Days)
        .ToList();

    public string TodayLabel =>
        DateTime.Today.ToString("dddd, d 'de' MMMM 'de' yyyy",
            new System.Globalization.CultureInfo("pt-PT"));

    public MainViewModel()
    {
        _completedDays = SaveData.LoadCompleted();

        foreach (var day in AllDays)
        {
            day.IsCompleted = _completedDays.Contains(day.UniqueId);
            day.OnCompletedChanged = OnDayCompletedChanged;
        }

        SelectedPhase = Phases.FirstOrDefault(p =>
            p.Weeks.Any(w => w.IsCurrent)) ?? Phases[0];

        SelectedWeek = SelectedPhase?.Weeks
            .FirstOrDefault(w => w.IsCurrent);

        PhaseAccentColor = SelectedPhase?.AccentColor ?? "#7c7cff";
        UpdateProgress();
    }

    private void OnDayCompletedChanged(DayTask day)
    {
        if (day.IsCompleted)
            _completedDays.Add(day.UniqueId);
        else
            _completedDays.Remove(day.UniqueId);

        SaveData.SaveCompleted(_completedDays);
        UpdateProgress();
    }

    private void UpdateProgress()
    {
        int total = AllDays.Count;
        ProgressPercent = total == 0 ? 0
            : (int)((_completedDays.Count / (double)total) * 100);
        ProgressBarWidth = (ProgressPercent / 100.0) * 880;
    }

    [RelayCommand]
    private void SelectPhase(Phase phase)
    {
        SelectedPhase = phase;
        SelectedWeek = phase.Weeks.FirstOrDefault(w => w.IsCurrent)
                       ?? phase.Weeks.FirstOrDefault();
        PhaseAccentColor = phase.AccentColor;
    }
}