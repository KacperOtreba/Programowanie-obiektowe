using System;

void ErrorColorChange(string comment){
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"\nBłąd :{comment}");
    Console.ResetColor();
}   

try{
System.Console.WriteLine("Podaj dwie liczby\n");
System.Console.Write("Podaj a: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Podaj y: ");
int y = int.Parse(Console.ReadLine());
// if (y == 0){
//     throw new Exception("Nie można dzielić przez zero");
// }
int result = x/y;
System.Console.Write($"Wynik dzielenia {x}/{y} = ");
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"{result:F3}");
Console.ResetColor();
}
catch (DivideByZeroException){
    // System.Console.WriteLine("Nie można dzielić przez zero");
    ErrorColorChange("Nie można dzielić przez zero");
}
catch (FormatException){
    // System.Console.WriteLine("Błędny format danych, podaj odpowiednią liczbę");
    ErrorColorChange("Błędny format danych, podaj odpowiednią liczbę");
}
catch (OverflowException){
    // System.Console.WriteLine($"Podana liczba jest błędna, podaj dane z zakresu <{int.MinValue}; {int.MaxValue}>");
    ErrorColorChange($"Podana liczba jest błędna, podaj dane z zakresu <{int.MinValue}; {int.MaxValue}>");
}
catch (Exception ex){
    // System.Console.WriteLine($"Błąd: {ex.Message}");
    ErrorColorChange(ex.Message);
}
