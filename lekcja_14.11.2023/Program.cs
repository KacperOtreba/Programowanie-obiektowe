using System.Reflection;

namespace lekcja_14._11._2023;
class Program
{
    static void Main(string[] args)
    {
        
        // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()
        // funkcja statyczna, która ustawia elementy tablicy SetArray()
        // funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
        try{
        int[] array = CreateArray("numbers");
        SetArray(array);
        DisplayArray(array);
        }
        catch(FormatException){
            System.Console.WriteLine("Podałeś złe dane, podaj liczbę w odpowiednim zakresie");
        }
        catch(Exception ex){
            System.Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
    public static int[] CreateArray(string name){
        System.Console.Write($"Podaj rozmiar tablicy {name}: ");
        int size = 0;
        try
        {
            size = Convert.ToInt32(Console.ReadLine());
            if (size<=0)
            {
                throw new ArgumentException("Rozmiar tablicy musi być dodatni");
            }
        }
        catch (ArgumentException exe)
        {
            System.Console.WriteLine(exe.Message);
        }
        int[] array = new int[size];
        return array;
    }
    
    public static void SetArray(int[] tab){
        for (int i = 0; i < tab.Length; i++)
        {
            System.Console.Write($"Podaj [{i+1}] liczbę: ");
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static void DisplayArray(int[] tab){
        System.Console.WriteLine("Zawartość tablicy: ");
        for (int i = 0; i < tab.Length; i++)
        {
            System.Console.WriteLine($"[{i}] = {tab[i]}");   
        }
    }
}
