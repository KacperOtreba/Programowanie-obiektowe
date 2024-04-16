using System.Security.Cryptography;

namespace lekcja_2024._03._19.classes{
    public enum CarStatus{
        New,
        Used,
        Historic
    }

    class Car{
        private string Brand;
        private string Model;
        private int YearOfProduction;
        private double EngineCapacity;
        private bool IsDiesel;
        private DateTime PurchaseDate;
        private CarStatus CarStatus;

        public Car(){
            Brand = "Unknown";
            Model = "Unknown";
            YearOfProduction = 0;
            EngineCapacity = 0;
            IsDiesel = false;
            PurchaseDate = DateTime.MinValue;
            CarStatus = CarStatus.New;
        }

        public Car(string brand, string model, int yearOfProduction) : this(){
            Brand = brand;
            Model = model;
            YearOfProduction = yearOfProduction;
        }

        public Car(string brand, string model, int yearOfProduction, double engineCapacity) : this(brand, model, yearOfProduction){
            EngineCapacity = engineCapacity;
        }

        public Car(string brand, string model, int yearOfProduction, double engineCapacity, bool isDiesel) : this(brand, model, yearOfProduction, engineCapacity){
            IsDiesel = isDiesel;
        }

        public Car(string brand, string model, int yearOfProduction, double engineCapacity, bool isDiesel, DateTime purchaseDate, CarStatus carStatus) : this(brand, model, yearOfProduction, engineCapacity, isDiesel){
            PurchaseDate = purchaseDate;
            CarStatus = carStatus;
        }

        public void GetInfo(){
            System.Console.Write($"Marka: {Brand}. Model: {Model}. Data produkcji: {YearOfProduction}. Pojemność śilnika: {EngineCapacity}. Data zakupu: {PurchaseDate.ToShortDateString()}. Status: {CarStatus}. Rodzaj paliwa: {(IsDiesel ? "Diesel" : "Benzyna")}");
            
        }

        public void CalculateCarAge(){
            int now = DateTime.Now.Year;
            int age =  now - PurchaseDate.Year;
        }
    }
}