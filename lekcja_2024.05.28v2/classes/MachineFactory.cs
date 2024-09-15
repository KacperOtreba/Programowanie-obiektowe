namespace _12_2_dziedziczenie_maszyny.classes;

internal class MachineFactory
{
    internal static MachineFactory CreateMachine(string type)
    {
        switch (type)
        {
            case "Koparka":
                return new Excavator("Nowa koparka", MachineType.Excavator);
            case "Dźwig":
                return new Crane("Nowy dźwig", MachineType.Crane);
            case "Spychacz":
                return new BullDozer("Nowy spychacz", MachineType.BullDozer);
            case "Ładowarka":
                return new Loader("Nowa ładowarka", MachineType.Loader);
            default:
                throw new ArgumentException("Nieznany typ maszyny");
            
        }
    }
}