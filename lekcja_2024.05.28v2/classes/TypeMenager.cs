namespace _12_2_dziedziczenie_maszyny.classes;

internal class MachineTypeManager
{
    private List<string> machineTypes = new List<string>();

    public MachineTypeManager()
    {
        machineTypes.Add("Koparka");
        machineTypes.Add("Dźwig");
        machineTypes.Add("Spychacz");
        machineTypes.Add("Ładowarka");
    }

    public void AddMachineType(string type)
    {
        if (!machineTypes.Contains(type))
        {
            machineTypes.Add(type);
            System.Console.WriteLine($"Pomyślnie dodano typ maszyny ({type})");
        }
        else{
            System.Console.WriteLine($"Typ maszyny {type} już istnieje");
        }
    }

    public void DisplayMachineTypes()
    {
        System.Console.WriteLine("\nDostępne typy maszyn:");
        foreach (var type in machineTypes)
        {
            System.Console.WriteLine($"- {type}");
        }
    }

    public bool IsValidType(string type)
    {
        return machineTypes.Contains(type);
    }
}