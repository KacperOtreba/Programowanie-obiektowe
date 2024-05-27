namespace lekcja_2024._05._21.classes
{
  internal class Excavator : Machine
  {
    public Excavator(string name) : base(name)
    {
    }

    //przesłonięcie metody wirtualnej
    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna kopanie");
    }

    //przeciążenie metody Stop
    public void Stop(string reason)
    {
      Console.WriteLine($"{Name} została zatrzymana z powodu: {reason}");
    }

    //symulacja kopania
    public void Dig()
    {
      Console.WriteLine($"{Name} kopie");
    }

    //przesłonięcie metody Work
    public override void Work()
    {
      Dig();
    }
  }
}