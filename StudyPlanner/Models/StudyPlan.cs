using CommunityToolkit.Mvvm.ComponentModel;

namespace StudyPlanner.Models;

public class Phase
{
    public int Id { get; set; }
    public string Label { get; set; } = "";
    public string Title { get; set; } = "";
    public string Period { get; set; } = "";
    public string Hours { get; set; } = "";
    public string FinalProject { get; set; } = "";
    public string AccentColor { get; set; } = "#7c7cff";
    public List<Week> Weeks { get; set; } = new();

    // Certificado simbólico gerado pela própria app ao concluir a fase
    public string SymbolicCertificateTitle { get; set; } = "";
    public string SymbolicCertificateDescription { get; set; } = "";

    // Certificação externa real sugerida para validar os conhecimentos da fase
    public string RealCertificationName { get; set; } = "";
    public string RealCertificationProvider { get; set; } = "";
    public string RealCertificationUrl { get; set; } = "";
}

public class Week
{
    public int Number { get; set; }
    public string Dates { get; set; } = "";
    public string Focus { get; set; } = "";
    public List<DayTask> Days { get; set; } = new();
    public bool IsCurrent { get; set; }
    public bool IsDone { get; set; }
}

public partial class DayTask : ObservableObject
{
    public string Day { get; set; } = "";
    public string Task { get; set; } = "";
    public string Description { get; set; } = "";
    public int UniqueId { get; set; }

    // Link clicável para a documentação oficial relacionada com a matéria do dia
    public string DocUrl { get; set; } = "";
    public string DocLabel { get; set; } = "";

    // Exercício de prática (LeetCode, HackerRank, etc.) relacionado com a matéria do dia
    public string PracticeUrl { get; set; } = "";
    public string PracticeLabel { get; set; } = "";

    [ObservableProperty]
    private bool _isCompleted;

    public Action<DayTask>? OnCompletedChanged { get; set; }

    partial void OnIsCompletedChanged(bool value)
    {
        OnCompletedChanged?.Invoke(this);
    }
}