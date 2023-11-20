namespace API.Interfaces
{
    public interface IGeneratePDFReport
    {
        // Tworzy raport w okre ś lonym stylu w formacie PDF
        // w raporcie powinny znale źć się informacje o:
        // najlepszym osobniku wraz z warto ścią funkcji celu,
        // liczbie wywo łań funkcji celu,
        // parametrach algorytmu
        void GenerateReport(string path);
    }
}
