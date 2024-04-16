using lekcja_2024._03._19.classes;
namespace lekcja_2024._03._19{

    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Toyota", "Tacoma", 2020, 2.0, true, new DateTime(2021, 3, 12), CarStatus.Used);
            c1.GetInfo();

            Car c2 = new Car(); // pusty
            c2.GetInfo();

            Car c3 = new Car("Mazda", "Rx7", 2016, 3.6, false, new DateTime(2022,5,21), CarStatus.New);
            c3.GetInfo();
        }
    }
}