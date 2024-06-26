namespace lekcja_2024._05._21.classes
{
  internal class Machine
  {
    public string Name { get; set; }
    public Machine(string name)
    {
      Name = name;
    }

    public virtual void Start()
    {
      Console.WriteLine($"{Name} została uruchomiona");
    }

    public void Stop()
    {
      Console.WriteLine($"{Name} została zatrzymana");
    }

    //symulacja pracy maszyny
    public virtual void Work()
    {
      Console.WriteLine($"{Name} pracuje");
    }
  }
}