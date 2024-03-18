// Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
// osób.
// Użyj tablicy, aby przechować wczytane imiona i wieki.
// Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
// Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
// większy niż 18 lat.
// Wypisz na ekranie zawartość tablicy, listy i słownika.

static void Main()
{
    System.Console.WriteLine("daj ilosc osob:");
    int n = ReadInt("daj liczbę osob",0,int.MaxValue);
    
    int[] ages = new int[n];
    string[] names = new string[n];
    for (int i = 0; i < n; i++)
    {
        names[i] = readstring($"daj imie osoby {i+1}: ");
        ages[i] = ReadInt($"daj wiek {i+1}: ",0,150);
    }

    List<string> namestostartwithA = names.Where(e => e.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

    System.Console.WriteLine("\nWyświetlenie tablicy imion i wiekow: ");
    PrintArray(names,ages);

    System.Console.WriteLine("imiona na a lub A");
    PrintList(namestostartwithA);

    Dictionary<string,int> adults = new Dictionary<string, int>();
    for (int i = 0; i < names.length; i++)
    {
        if(ages[i] >= 18)
        {
            adults.Add(names[i],ages[i]);
        }
    }

    PrintDictionary(adults);



    Console.ReadKey();
}
private static void PrintArray(string[] names,int[] ages)
{
    for (int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine(names[i]+" - "+ ages[i]);
    }
}

private static void PrintList(List<string> names)
{
    foreach (var item in names)
    {
        System.Console.WriteLine(item);   
    }
}

private static void PrintDictionary(Dictionary<string,int> dictionary)
{
    foreach (var item in dictionary)
    {
        System.Console.WriteLine(item);   
    }
}

static int ReadInt(string prompt,int low, int high)
{
    int result;
    bool valid;
    do
    {
        System.Console.Write(prompt);
        valid = int.TryParse(Console.ReadLine(),out result) && result >= low && result <= high;
        if (!valid)
        {
            System.Console.WriteLine($"podaj liczbę od {low} do {high}: ");
        }
    } while (!valid);
    return result;
}

static string readstring(string prompt){
    string result;
    do
    {
        System.Console.Write(prompt);
        result = Console.ReadLine();
        if (string.IsNullOrEmpty(result))
        {
            System.Console.WriteLine("Podaj nie pusty ciąg znaków");
        }
    } while (string.IsNullOrEmpty(result));
    return result;
}