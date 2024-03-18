using kartkowka1.classes;
namespace kartkowka1{

internal class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal();
        Person p1 = new Person();
        a1.Name = "Radek";
        a1.Species = "Ssak";
        a1.Color = "Żółty";
        a1.Age = 16;
        a1.Weight = 216.9F;
        a1.Owner = p1;
        a1.cechy = cechy.Ssak;
        p1.Name = "Jakub";
        p1.Surname = "Różalowski";
        p1.Birth = new DateTime(2008, 2, 20);
        p1.animals_names = new List<string> {"Antek", "Basia", "Kasia"};
        System.Console.WriteLine(a1.GetInfo());
        System.Console.WriteLine(p1.GetAnimalsNames());
    }
}

}