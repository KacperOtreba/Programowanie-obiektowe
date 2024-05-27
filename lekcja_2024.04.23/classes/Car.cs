namespace lekcja_2024._04._23.classes;

class Car : Vehicle
{
    public byte NumberOfDoors { get; set; }
    public int CurrentGear { get; private set; }
    public int MaxGear { get; set; }
    public bool isAutomatic { get; set; }

    public override string StartEngine() // Przesłanianie metody bazowej
    {
        return "Silnik samochodu został uruchomiony";
    }

    public override string StopEngine()
    {
        return "Silnik samochodu został zatrzymany";
    }

    public void ChangeGear(byte gear)
    {
        if (!isAutomatic)
        {
            if (gear < MaxGear && gear >= 0)
            {
                CurrentGear = gear;
                System.Console.WriteLine($"\nZmiana biegu na {gear}");
            }
            else
            {
                System.Console.WriteLine("\nNieprawidłowy bieg");
            }
        }
        else
        {
            System.Console.WriteLine("Ten samochód ma automatyczną skrzynie biegów!");
        }
    }

    private void AutomaticGearChange(int speed)
    {
        if (isAutomatic)
        {
            if (speed < 20)
            {
                CurrentGear = 1;   
            }
            else if (speed > 20 && speed < 50)
            {
                CurrentGear = 2;
            }
            else
            {
                CurrentGear = 3;
            }
            System.Console.WriteLine($"\nAutomatyczna zmiana biegu na {CurrentGear} dla prędkości {speed} km/h");
        }
        else
        {
            System.Console.WriteLine("\nAuto posiada manualną skrzynie biegów");
        }
    }
}