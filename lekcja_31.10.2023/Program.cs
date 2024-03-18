// Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
// Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
// Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
// Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.
// using System;

void Error(string comment){
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"Błąd: {comment}\n");
    Console.ResetColor();
}

// while(true){
// try{
// System.Console.Write("Podaj liczbę całkowitą nieujemną: ");
// string liczba1 = Convert.ToString(Console.ReadLine());

// if (liczba1.Equals("q")){
//     return;
// }
// int liczba = Convert.ToInt32(liczba1);
// if (liczba < 0){
//     Console.ForegroundColor = ConsoleColor.Red;
//     throw new ArgumentOutOfRangeException("Podałeś ujemną liczbę :(, wprowadź nieujemną");
//     Console.ResetColor();
// }

// double pierwiastek = Math.Sqrt(liczba);
// Console.ForegroundColor = ConsoleColor.Green;
// System.Console.WriteLine($"Pierwiastek z tej liczby to {pierwiastek:F2}");
// Console.ResetColor();
// break;
// }
// catch(ArgumentOutOfRangeException ex){
//     Error(ex.ParamName);
// }
// catch(FormatException){
//     Error("Nie podałeś liczby, wprowadź liczbę");
// }
// catch(Exception ex){
//     Error(ex.Message);
// }
// finally{
//     Console.ForegroundColor = ConsoleColor.Blue;
//     System.Console.WriteLine("Dziekujemy za korzystanie z naszych usług");
//     Console.ResetColor();
// }
// }




/*Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException
i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException
i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. 
Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException
i wyświetlić odpowiedni komunikat. 
Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. */


while (true){
try{
int[] M = new int[5];
for (int i = 0; i < 5; i++)
{
    System.Console.Write($"Podaj {i+1} liczbę, zapiszemy ją w tablicy: ");
    string x = Console.ReadLine();
    if (x == "q"){
        return;
    }
    M[i] = Convert.ToInt32(x);
}

System.Console.Write("Podaj indeks tablicy (0-4): ");
int index = Convert.ToInt32(Console.ReadLine());

if (index > 4 || index < 0){
    throw new ArgumentOutOfRangeException("Nie ma takiego indeksu, wprowadź w zakresie 0-4");
}

System.Console.WriteLine();
System.Console.Write($"Liczba która znajduje się pod tym indeksem to: ");
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine(M[index]);
Console.ResetColor();
break;
}
catch(ArgumentOutOfRangeException ex){
    Error(ex.ParamName);
}
catch(FormatException){
    Error("Nie podałeś liczby całkowitej");
}
catch(Exception ex){
    Error(ex.Message);
}
}
