namespace lekcja_2024._05._21.classes
{
  internal class Loader : Machine
  {
    public Loader(string name) : base(name)
    {
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna ładowanie materiałów");
    }

    public void Load()
    {
      Console.WriteLine($"{Name} ładuje materiał");
    }

    public override void Work()
    {
      Load();
    }
  }
}