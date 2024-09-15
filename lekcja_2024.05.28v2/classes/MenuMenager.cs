
namespace _12_2_dziedziczenie_maszyny.classes{
internal class MenuManager
{
    public void DisplayMenu()
    {
        // Console.Clear();
        System.Console.WriteLine("\nMenu:");
        System.Console.WriteLine("1. Wyświetl wszystkie maszyny");
        System.Console.WriteLine("2. Uruchom wszystkie maszyyny");
        System.Console.WriteLine("3. Pracuj wszystkimi maszynami");
        System.Console.WriteLine("4. Zatrzymaj wszyskie maszyny");
        System.Console.WriteLine("5. Wyświetl status wszystkich maszyn");
        System.Console.WriteLine("6. Losowe awarie maszyn");
        System.Console.WriteLine("7. Napraw wszystkie maszyny");
        System.Console.WriteLine("8. Dodaj nowy typ maszyny");
        System.Console.WriteLine("9. Dodaj nową maszynę");
        System.Console.WriteLine("10. Wyjście z programu");
        System.Console.WriteLine();
    }

    public string GetUserInput()
    {
        string input = Console.ReadLine();
        while (!IsValidInput(input,1,10))
        {
            ShowErrorMessage("Nieprawidłowa opcja, spróbuj ponownie: ");
            input = Console.ReadLine();
        }
        return input;
    }

    private void ShowErrorMessage(string message)
    {
        System.Console.WriteLine(message);
    }

    private bool IsValidInput(string input, byte min, byte max){
        return int.TryParse(input, out int number) && number >= min && number <= max;
    }

    public void ExecuteAction(string userInput, MachineSimulator simulator, MachineTypeManager typeManager)
    {
        int action = int.Parse(userInput);
        switch (action){
            case 1:
                simulator.DisplayAllMachines();
                break;
            case 2:
                simulator.StartAll();
                break;
            case 3:
                simulator.WorkAll();
                break;
            case 4:
                simulator.StopAll();
                break;
            case 5:
                // simulator.DisplayStatusAll();
                break;
            case 6:
                // simulator.RandomFailure();
                break;
            case 7:
                // simulator.RepairAll();
                break;
            case 8:
                System.Console.Write("Podaj nazwę nowego typu maszyny: ");
                string newType = Console.ReadLine();
                typeManager.AddMachineType(newType);
                break;
            case 9:
                simulator.AddNewMachine(typeManager);
                break;
            case 10:
                System.Console.WriteLine("Wyjście z programu");
                break;
            default:
                ShowErrorMessage("Nieprawidłowa opcja, spróbuj ponownie: ");
                break;
        }
    }
}
}