namespace API.Interfaces
{
    public interface IStateReader
    {
        // Metoda wczytuj ąca z pliku stan algorytmu (w odpowiednim formacie ).
        // Stan algorytmu : numer iteracji , liczba wywo łań funkcji celu ,
        // populacja wraz z warto ścią funkcji dopasowania
        void LoadFromFileStateOfAlghoritm(string path);
    }
}
