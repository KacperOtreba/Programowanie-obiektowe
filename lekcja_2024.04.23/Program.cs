using lekcja_2024._04._23.classes;
namespace lekcja_2024._04._23;

class Program
{
    static void Main(string[] args)
    {
        Vehicle v = new Vehicle();
        v.Brand = "Lamborghini";
        System.Console.WriteLine(v.Brand);
        System.Console.WriteLine($"Pojazd: {v.StartEngine()}");
        

        Car car = new Car();
        car.Brand = "Fiat";
        System.Console.WriteLine(car.Brand);
        System.Console.WriteLine($"Pojazd: {car.StartEngine()}");
        car.NumberOfDoors = 4;

        Car car1 = new Car() {Brand = "Toyota", Model = "Supra", FuelType = FuelType.Petrol, NumberOfDoors = 3, MaxGear = 5, isAutomatic = false};

    }
}
