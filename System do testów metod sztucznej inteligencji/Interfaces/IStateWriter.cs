namespace API.Interfaces
{
    public interface IStateWriter
    {
        // Metoda zapisuj ąca do pliku tekstowego stan algorytmu (w odpowiednim formacie).
        // Stan algorytmu : numer iteracji , liczba wywo łań funkcji celu ,
        // populacja wraz z warto ścią funkcji dopasowania
        void SaveToFileStateOfAlghoritm(string path);
    }
}
