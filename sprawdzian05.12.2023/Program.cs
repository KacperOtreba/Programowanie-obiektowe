// grupa 1
// Napisz program, który:

// Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową
// o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury

// Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
// P=a2

// Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
// O=4a

// W funkcji Main:
// Deklaruje zmienną n i przypisuje jej wartość 5.

// Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.

// Wyświetla na ekranie zawartość tablicy tablica.

// Dla każdego elementu tablicy tablica:
// Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.

// Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.

// Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.

// Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu

namespace sprawdzian05._12._2023;
class Program
{
    static void Main(string[] args)
    {
        int n1 = 5;
        int[] tablica1 = UtworzTabliceLiczb1(n1);
        foreach (int item in tablica1)
        {
            System.Console.Write(item+" ");
        }

        foreach (int item in tablica1)
        {
            int pole1 = ObliczPole1(item);
            int obwod1 = ObliczObwod1(item);
            System.Console.WriteLine("Dla kwadratu o boku "+item+"[j]");
            System.Console.Write("Pole to "+pole1+"[j]");
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("\u00B2");
            System.Console.OutputEncoding = System.Text.Encoding.Default;
            System.Console.WriteLine("Obwód to "+obwod1+"[j]");
            System.Console.WriteLine();
        }
        InfoZIndexu1(tablica1);
    }

    static int[] UtworzTabliceLiczb1(int n1){
    int[] T = new int[n1];
    for (int i = 0; i < n1; i++)
    {
        T[i] = GetIntFromUser1();
    }
    return T;
    }

    static int GetIntFromUser1(){
        System.Console.WriteLine("Podaj liczbę w zakresie <1;10>");
        while(true){
            if (int.TryParse(Console.ReadLine(), out int number1) && number1 < 11 && number1 > 0){
                return number1;
            }
            System.Console.WriteLine("Podałeś złe dane, podaj liczbę całkowitą w zakresie <1;10>");
        }
    }
    static int GetIntFromUser2_1(){
        System.Console.WriteLine("Podaj liczbę w zakresie <0;4>");
        while(true){
            if (int.TryParse(Console.ReadLine(), out int number1) && number1 < 5 && number1 >= 0){
                return number1;
            }
            System.Console.WriteLine("Podałeś złe dane, podaj liczbę całkowitą w zakresie <0;4>");
        }
    }

    static int ObliczPole1(int a1){
        return a1*a1;
    }

    static int ObliczObwod1(int a1){
        return 4*a1;
    }

    static void InfoZIndexu1(int[] T1){
        try{
        int index1 = GetIntFromUser2_1();
        int pole1 = ObliczPole1(T1[index1]);
        int obwod1 = ObliczObwod1(T1[index1]);
        System.Console.WriteLine("Dla kwadratu o boku "+ T1[index1]+"[j]");
        System.Console.Write("Pole to "+pole1+"[j]");
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("\u00B2");
        System.Console.WriteLine("Obwód to "+ obwod1+"[j]");
        }
        catch (IndexOutOfRangeException){
            System.Console.WriteLine($"Podałeś zły index, podaj liczbę całkowitą z zakresu <0;{T1.Length-1}>");
        }
        catch (FormatException){
            System.Console.WriteLine($"Podałeś zły index, podaj liczbę całkowitą z zakresu <0;{T1.Length-1}>");
        }
    }
}
