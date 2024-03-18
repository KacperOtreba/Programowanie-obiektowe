// Napisz kod na pole prostokąta

void Error(string comment){
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"\nBłąd: {comment}\n");
    Console.ResetColor();
}

System.Console.WriteLine("Podaj boki prostokąta w cm");
while (true){
try{
System.Console.Write("Podaj pierwszy bok w cm: ");
int x = int.Parse(Console.ReadLine());

if (x <= 0){
    throw new Exception("Bok nie może mieć długości zerowej lub ujemnej");
}

System.Console.Write("Podaj drugi bok w cm: ");
int y = int.Parse(Console.ReadLine());

if (y <= 0){
    throw new Exception("Bok nie może mieć długości zerowej lub ujemnej");
}

double result = x * y;
System.Console.Write($"Pole tego prostokąta to: {result:F3}cm");
Console.OutputEncoding = System.Text.Encoding.Unicode;
System.Console.Write("\u00B2");
Console.OutputEncoding = System.Text.Encoding.Default;
break;
}
catch (FormatException){
    Error("Podałeś złe dane, wprowadź tylko liczby\n");
}
catch(OverflowException){
    Error($"Podałeś zbyt dużą lub zbyt małą liczbę, wprowadź liczby z przedziału <{int.MinValue} ; {int.MaxValue}>\n");
}
catch(Exception ex){
    Error(ex.Message);
}
}