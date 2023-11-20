namespace API.Interfaces
{
    public interface IGenerateTextReport
    {
        // Tworzy raport w postaci łań cucha znaków
        // w raporcie powinny znale źć się informacje o:
        // najlepszym osobniku wraz z warto ścią funkcji celu,
        // liczbie wywołań funkcji celu,
        // parametrach algorytmu
        string ReportString { get; set; }
    }
}
