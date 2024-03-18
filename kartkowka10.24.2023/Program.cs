// Gr2
// napisz program który oblicza pole prostokąta
using System;
try{
System.Console.WriteLine("Podaj dwa boki");
int x = 0;
int y = 0;
while (x <= 0){
    System.Console.Write("Podaj długość pierwszego boku w cm: ");
    x = Convert.ToInt32(Console.ReadLine());
    if (x <= 0){
        System.Console.WriteLine("Bok nie może mieć długości ujemnej lub zerowej\n");
    }
}
while (y <= 0){
    System.Console.Write("Podaj długość drugiego boku w cm: ");
    y = Convert.ToInt32(Console.ReadLine());
    if (y <= 0){
        System.Console.WriteLine("Bok nie może mieć długości ujemnej lub zerowej\n");
    }
}
double result = x * y;
System.Console.WriteLine($"Pole tego prostokąta to: {result}cm2");
}
catch(FormatException){
    System.Console.WriteLine("Podane dane nie są prawidłowe");
}
catch(OverflowException){
    System.Console.WriteLine($"Podana liczba jest zbyt duża lub zbyt mała, podaj liczbe w wielkościach <{int.MinValue}; {int.MaxValue}>");
}
catch (Exception ex){
    System.Console.WriteLine($"Błąd: {ex.Message}");
}