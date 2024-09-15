using lekcja_2024._05._21.classes;
namespace lekcja_2024._05._21
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      Machine machine = new Machine("M-100");

      Excavator excavator = new Excavator("E-200");
      excavator.Start();
      excavator.Stop("awaria silnika");
      excavator.Work();
      //excavator.Dig();
      */

      MachineSimulator simulator = new MachineSimulator();

      simulator.AddMachine(new Excavator("Koparka E-100"));
      simulator.AddMachine(new Crane("Dźwig D-100"));
      simulator.AddMachine(new Bulldozer("Spychacz B-100"));
      simulator.AddMachine(new Loader("Ładowacz L-100"));

      simulator.StartAll();
      simulator.StopAll();
      simulator.DisplayAllMachines();

    }
  }
}