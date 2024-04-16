namespace lekcja_2024._04._09.classes
{
    internal class Car
        {
            // public Car(string name, double speed)
            // {
            //     Name = name;
            //     Speed = speed;
            // }
            // ~Car()
            // {
            //     System.Console.WriteLine($"Samochód {Name} został zniszczony");
            // }

            // public void StartRace()
            // {
            //     System.Console.WriteLine($"Samochód {Name} rozpoczął wyścig");
            // }
            public string Brand { get; set; }
            public string Model { get; set; }
            public bool IsDamaged { get; set; }

            public Car(string brand, string model)
            {
                Brand = brand;
                Model = model;
                IsDamaged = false;
            }

            ~Car()
            {
                System.Console.WriteLine($"Samochoód {Brand} {Model} jest zezłomowany.");
            }

            public void Drive()
            {
                if (IsDamaged)
                {
                    System.Console.WriteLine($"Niestety samochód {Brand} {Model} jest uszkodony i niezdolny do jazdy");
                }
                else
                {
                    System.Console.WriteLine($"Samochód {Brand} {Model} jedzie.");
                }
            }

            public void SimulateRandomDamage()
            {
                Random r = new Random();
                int damageType = r.Next(1,4);
                switch (damageType)
                {
                    case 1:
                        System.Console.WriteLine($"Samochód {Brand} {Model} ma przebitą oponę!");
                        break;
                    case 2:
                        System.Console.WriteLine($"Samochód {Brand} {Model} ma uszkodony silnik!");
                        break;
                    case 3:
                        System.Console.WriteLine($"Samochód {Brand} {Model} ma zepsute światła!");
                        break;
                }

                IsDamaged = true;
            }


        }
}
