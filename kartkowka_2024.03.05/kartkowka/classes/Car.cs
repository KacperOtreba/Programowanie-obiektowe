namespace kartkowka.classes{
    enum Colors{
        white,
        black,
        red,
        green,
        grey
    }

internal class Car
{
    public string Brand{ get; set;}
    public string Model{ get; set;}
    public Colors Color{ get; set;}
    public ushort Year{ get; set;}
    public float Price{ get; set;}
    public Person Owner{ get; set;}
    
    public Car(string brand, string model, Colors color, ushort year, float price, Person owner)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        Price = price;
        Owner = owner;
    }
    public string GetInfo()
    {
        return "Marka: "+Brand+", Model: "+ Model+ ", Kolor: "+ Color+", Rok: "+ Year+", Cena: "+Price+"PLN, Właściciel: "+Owner.Name+" "+Owner.Surname+", data urodzenia: "+Owner.Birth.ToShortDateString()+".";
    }
}
}