#pragma warning disable
namespace lekcja_2024._04._23.classes;

// Typ wyliczeniowy dla rodzajów paliwa
public enum FuelType
{
    Petrol, // benzyna
    Diesel, // olej napędowy
    Electric // elektryczny
}

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double FuelLevel { get; private set; }
    public FuelType FuelType { get; set; }
    public ushort Speed { get; set; } // aktualna prędkość pojazdu

    public virtual string StartEngine()
    {
        return "Silnik został uruchomiony.";
    }

    public virtual string StopEngine()
    {
        return "Silnik został zatrzymany";
    }

    public void Refuel(double amount)
    {
        System.Console.WriteLine($"Zatankowano {amount} litrów paliwa");
    }
}