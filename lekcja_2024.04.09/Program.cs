// DESTRUKTORY
using System.Net;
using lekcja_2024._04._09.classes;
namespace lekcja_2024._04._09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car car1 = new Car("Ferrari", 300);
            // Car car2 = new Car("Porsche", 280);
            // Car car3 = new Car("Lamborghini", 320);

            // car1.StartRace();
            // car2.StartRace();
            // car3.StartRace();

            // car1 = null;
            // GC.Collect();

            // Console.ReadKey();
            List<Car> cars= new List<Car>();
            Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();
            while (true)
            {
                System.Console.WriteLine("\nMenu syulatora do jazdy samochodem");
                System.Console.WriteLine("1. Dodaj samochód");
                System.Console.WriteLine("2. Wyświetl listę samochodów");
                System.Console.WriteLine("3. Jedź samochodem");
                System.Console.WriteLine("4. Symuluj losowe uszkodzenie");
                System.Console.WriteLine("5. Zezłomuj samochód");
                System.Console.WriteLine("6. Wyjście");
                System.Console.Write("Wybierz jedną opcję (1-6): ");

                int choice = Convert.ToInt32(System.Console.ReadLine());

                switch (choice){
                    case 1:
                        System.Console.Write("Podaj markę: ");
                        string brand = Console.ReadLine();
                        System.Console.Write("Podaj model: ");
                        string model = Console.ReadLine();
                        Car newCar = new Car(brand,model);
                        cars.Add(newCar);
                        carDictionary[cars.Count] = newCar;
                        System.Console.WriteLine($"Dodano samochód {brand} {model}");
                        break;
                    
                    case 2:
                        System.Console.WriteLine("Lista samochodów:");
                        foreach (Car car in cars)
                        {
                            System.Console.WriteLine($"{car.Brand} {car.Model}");
                        }
                        break;
                    
                    case 3:
                        System.Console.Write("Podaj numer samochodu do jazdy: ");
                        int carNumber = Convert.ToInt32(System.Console.ReadLine());
                        if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
                        {
                            selectedCar.Drive();
                        }
                        else
                        {
                            System.Console.WriteLine("\nNieprawidłowy numer samochodu.");
                        }
                        break;

                    case 4:
                        System.Console.Write("Podaj numer samochodu do symulacji uszkodzenia: ");
                        int damagedCarNumber = int.Parse(System.Console.ReadLine());
                        if (carDictionary.TryGetValue(damagedCarNumber, out Car damagedCar))
                        {
                            damagedCar.SimulateRandomDamage();
                        }
                        else
                        {
                            System.Console.WriteLine("Nieprawidłowy numer samochodu!");
                        }

                        break;

                    case 5:
                        System.Console.Write("Podaj numer samochodu do zezłowowania: ");
                        int scrappedCarNumber = int.Parse(System.Console.ReadLine());
                        if (carDictionary.TryGetValue(scrappedCarNumber, out Car scrappedCar))
                        {
                            scrappedCar = null;
                            cars.RemoveAt(scrappedCarNumber-1);
                            GC.Collect();
                            System.Console.WriteLine($"Samochód {scrappedCarNumber} został zezłomowany");
                        }

                        break;

                    case 6:
                            System.Console.WriteLine("Zamykanie symulatora....");
                        return;
                    
                    default:
                        break;
                }

            }
        }
    }
}