// Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
// Następnie program wyświetla sumę wszystkich elementów tablicy.
// W celu zabezpieczenia programu przed niepoprawnymi danymi wejściowymi, 
// użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest liczbą całkowitą. 
// Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.

// int[] T = new int[5];
// for (int i = 0; i <= 4; i++)
// {
// System.Console.Write($"Podaj {i+1} liczbę: ");
// string input = Console.ReadLine();
// if (int.TryParse(input, out int number)){
//     T[i] = number;
// }
// else{
//     System.Console.WriteLine("Złe dane\n");
//     i--;
// }

// }

// int suma = 0;
// foreach (var item in T)
// {
//     suma += item;
// }
// System.Console.WriteLine(suma);


// Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy.
// Użyj języka programowania C# i środowiska Visual Studio.
// Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers.
// Użyj pętli for, aby pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers.
// Wyświetl na ekranie komunikat, który prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i zweryfikować.
// Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
// Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą całkowitą i przypisać ją do zmiennej input.
// Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
// Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers i zwrócić sumę.
// Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum.
// Wyświetl na ekranie komunikat, który pokazuje sumę podanych liczb.



int GetIntegerFromUser(){
    while (true)
    {
        System.Console.Write("Podaj liczbę całowitą: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number)){
            return number;
        }
        else{
            System.Console.WriteLine("Niepoprawna wartość");
        }
    }
}

int CalculateSum(int[] numbers){
    int suma = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        suma += numbers[i];
    }
    return suma;
}

int[] numbers = new int[5];
int suma = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = GetIntegerFromUser();
}
suma = CalculateSum(numbers);

System.Console.WriteLine($"Suma elementów tej tablicy to {suma}");