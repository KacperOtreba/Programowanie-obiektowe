namespace lekcja_2024._05._21.classes
{
  internal class Crane : Machine
  {
    public Crane(string name) : base(name)
    {
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna podnoszenie ładunku");
    }

    //symulacja podnoszenia ładunku
    public void Lift()
    {
      Console.WriteLine($"{Name} podnosi ładunek");
    }

    public void Work()
    {
      Lift();
    }
  }
}