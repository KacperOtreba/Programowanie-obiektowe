// using System;
// double a;
// if (double.TryParse(Console.ReadLine(),out a))
// {
//     System.Console.WriteLine(a);
// }
// else{
//     System.Console.WriteLine("Złe dane!");
// }
while(true)
{

System.Console.Write("Podaj a: ");
double a;
while (!double.TryParse(Console.ReadLine(), out a) || a<=0)
{
    System.Console.Write("Wpisz prawidłowe dane: ");
}

System.Console.Write("Podaj b: ");
double b;
while (!double.TryParse(Console.ReadLine(), out b) || b<=0)
{
    System.Console.Write("Wpisz prawidłowe dane: ");
}

System.Console.Write("Podaj c: ");
double c;
while (!double.TryParse(Console.ReadLine(), out c) || c<=0)
{
    System.Console.Write("Wpisz prawidłowe dane: ");
}

bool IsTriangle(double a, double b, double c){
    if (a < b + c && b < c + a && c < a + b){
        return true;
    }
    else{
        return false;
    }
}


static double PoleHerona(double a, double b, double c){
    double p = ((a+b+c)/2);
    double p1 = p-a;
    double p3 = p-b;
    double p2 = p-c;
    return Math.Sqrt(p*p1*p2*p3);
}

double area = PoleHerona(a,b,c);

if (!IsTriangle(a,b,c))
{
    System.Console.WriteLine("Taki trójkąt nie istnieje");
    Thread.Sleep(3000);
    Console.Clear();
    continue;
}
else{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    System.Console.WriteLine("Pole trójkąta o bokach {0}, {1}, {2} wynosi: {3:F4}cm\u00B2", a, b, c, area);
    Console.OutputEncoding = System.Text.Encoding.Default;
    break;
}
}


