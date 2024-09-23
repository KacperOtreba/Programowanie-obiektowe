namespace gr_1_Otręba_Kacper;

class Program
{
    public class Vehicle()
    {
        public string Brand;
        public string Model;
        public virtual void DisplayInfo()
        {
            System.Console.WriteLine($"Informacje o pojeździe: {Brand}, {Model}");
        }
    }

    public class Car() : Vehicle
    {
        public int NumbersOfDoors;
        public Car(string brand, string model, int numbersOfDoors) : this()
        {
            Brand = brand;
            Model = model;
            NumbersOfDoors = numbersOfDoors;
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Informacje: {Brand}, {Model}, {NumbersOfDoors}");
        }
    }
    public class Motorcycle() : Vehicle
    {
        public bool HasSideCar;
        public Motorcycle(string brand, string model, bool hasSideCar) : this()
        {
            Brand = brand;
            Model = model;
            HasSideCar = hasSideCar;
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Informacje: {Brand}, {Model}, {HasSideCar}");
        }
    }
    static void Main(string[] args)
    {
        Car c1 = new Car("Toyota", "Prius", 4);
        c1.DisplayInfo();
        Motorcycle m1 = new Motorcycle("Suzuki", "Hayabusa", false);
        m1.DisplayInfo();
    }

    public static string GetValidInputS(string prompt)
    {
        string result = "";
        while (true){
            if (string.TryParse(Console.ReadLine(), out result))
            {
                return result;
            }
            else{
                Console.WriteLine("Błąd danych, spróbuj ponownie.");
            }
        }
    }
}
