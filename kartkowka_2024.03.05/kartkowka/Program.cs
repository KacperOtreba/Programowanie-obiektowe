using kartkowka.classes;
namespace kartkowka{
internal class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Jakub", "Nowak");

        p1.Birth = new DateTime(1998, 05, 21);

        // System.Console.WriteLine(p1.Birth.ToShortDateString());

        p1.kids_names = new string[] {"Asia", "Basia", "Maciek", "Maryla"};

        System.Console.WriteLine(p1.GetKidsNames());

        Car c1 = new Car("Toyota", "Corolla", Colors.grey, 2020, 82900, p1);
        
        System.Console.WriteLine(c1.GetInfo());
    }
}
}