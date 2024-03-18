using System.Net;

namespace lekcja_2023._12._05;
class Program
{
    static void Main(string[] args)
    {
        // Dictionary<int,string> slownik = new Dictionary<int, string>();
        // slownik.Add(1, "Franek");
        // slownik.Add(2, "Anna");
        // slownik.Add(3, "Tomasz");

        // foreach (var item in slownik)
        // {
        //     System.Console.WriteLine(item.Value);
        // }
        // System.Console.WriteLine();
        
        // //////////////////////////////////////////////////
        // // Tworzymy słownik który przechowuje łańcuchy jako klucze i liczby jako wartości
        // Dictionary<string, int> slownik1 = new Dictionary<string, int>();
        
        // // dodajemy kilka par klucz-wartość do słownika
        // slownik1.Add("Jeden", 1);
        // slownik1.Add("Dwa", 2);
        // slownik1.Add("Trzy", 3);

        // // wyświetlenie zawartości słownika za pomocą pętli foreach
        // foreach (var item in slownik1)
        // {
        //     System.Console.WriteLine($"Klucz: {item.Key}, warotść: {item.Value}");
        // }
        // System.Console.WriteLine();

        // foreach (KeyValuePair<string, int> item in slownik1)
        // {
        //     System.Console.WriteLine($"Klucz: {item.Key}, warotść: {item.Value}");
        // }
        // System.Console.WriteLine();


        // //////////////////////////////////////////////////////////////
        // // Utwórz słownik który może przechowywać łańcuchy jako klucze i wartości
        // Dictionary<string, string> capital = new Dictionary<string, string>();

        // // dodaj kilka par klucz-wartość
        // capital = new Dictionary<string, string>
        // {
        //     {"Polska", "Warszawa"},
        //     {"Niemcy", "Berlin"},
        //     {"Francja","Paryż"},
        //     {"Czechy", "Praga"}
        // };

        // foreach (var item in capital)
        // {
        //     System.Console.WriteLine($"Kraj: {item.Key}  Stolica: {item.Value}");
        // }
        // System.Console.WriteLine();

        // /////////////////////////////////////
        // Dictionary<string, string> phones = new Dictionary<string, string>();
        // phones.Add("+48 123 456 789", "Katarzyna");
        // phones.Add("+48 123 444 789", "Tomek");
        // phones.Add("+48 123 555 789", "Andrzej");

        // foreach (KeyValuePair<string,string> item in phones)
        // {
        //     System.Console.WriteLine($"Numer to: {item.Key}, osoba: {item.Value}");
        // }
        // System.Console.WriteLine();


        // /////////////////////////////////////////
        // Dictionary<string, string> animals = new Dictionary<string, string>();
        // animals = new Dictionary<string, string>
        // {
        //     {"pies", "hauhau"},
        //     {"krowa", "muuuuu"},
        //     {"kot" , "miał"},
        //     {"koń", "iha"}
        // };

        // foreach (var item in animals)
        // {
        //     System.Console.WriteLine($"Zwierze: {item.Key}, odgłos: {item.Value}");
        // }
        // System.Console.WriteLine();

        // ////////////////////////////////////////////
        // Dictionary<string, string> colors = new Dictionary<string,string>();
        // colors = new Dictionary<string, string>
        // {
        //     {"biały", "#FFFFFF"},
        //     {"czarny", "#000000"},
        //     {"czerwony", "#FF0000"},
        //     {"zielony", "#00FF00"},
        //     {"niebieski", "#0000FF"}
        // };

        // foreach (var item in colors)
        // {
        //     System.Console.WriteLine($"kolor: {item.Key}, jego hex: {item.Value}");
        // }
        // System.Console.WriteLine();

        // ////////////////////////////////////////////////////
        // Dictionary<string,string> data = new Dictionary<string, string>();

        // // popros użytkownika o podanie liczby par klucz-wartość
        // System.Console.Write("Ile par klucz-wartość chesz wprowadzić: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        
        // // w pętli dodajemy pary podane przez użytkownika
        // for (int i = 0; i < n; i++)
        // {
        //     System.Console.Write("Podaj klucz: ");
        //     string klucz = Console.ReadLine();
        //     System.Console.Write("Podaj wartość: ");
        //     string wart = Console.ReadLine();
        //     data.Add(klucz, wart);
        // }

        // foreach (var item in data)
        // {
        //     System.Console.WriteLine($"Klucz: {item.Key}, wartość: {item.Value}");
        // }
        // System.Console.WriteLine();

        // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
        // Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
        // Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
        // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
        // Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
        // Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
        // Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
        // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.
        List<int> ints = new List<int>() {1,2,3,2,4,1,5,2};
        foreach (var item in Slownik(ints))
        {
            System.Console.WriteLine($"Key: {item.Key}; Value: {item.Value}");
        }
        System.Console.WriteLine();

        string ciag = Console.ReadLine();
        if (!int.TryParse(ciag, out int numbers)){
            System.Console.WriteLine($"{ciag} nie jest poprawną liczbą całkowitą");
        }
        else{
            System.Console.WriteLine($"{ciag} jest poprawną liczbą całkowitą");
        }

    }

    public static Dictionary<int, int> Slownik(List<int> lista){
        Dictionary<int, int> slownik = new Dictionary<int, int>();
        foreach (var item in lista)
        {
            if (slownik.ContainsKey(item)){
                slownik[item]++;
            }
            else{
                slownik.Add(item, 1);
            }
        }
        return slownik;
    }
}