namespace lekcja_2024._05._21.classes
{
  internal class Bulldozer : Machine
  {
    public Bulldozer(string name) : base(name)
    {
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna równanie terenu");
    }

    //symulacja równania terenu
    public void Flatten()
    {
      Console.WriteLine($"{Name} równa teren");
    }

    public override void Work()
    {
      Flatten();
    }
  }
}