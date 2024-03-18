using System.Dynamic;
using System.Security.Cryptography;

namespace kartkowka1.classes{
    public enum cechy{
        Ssak = 1,
        Gad = 2,
        Płaz = 3

    }
    internal class Animal
    {
        public string Name{get; set; }
        public string Species{get; set; }
        public string Color{get; set; }
        public ushort Age{get; set;}
        public float Weight{get; set; }
        public Person Owner{get; set; }
        public cechy cechy{get; set; }

        public string GetInfo()
        {
            return "Imię: "+Name+", Gatunek: "+Species+", cechy: "+cechy+ "kolor: "+Color+", wiek: "+Age+"lat(a), waga: "+Weight+"kg, właściciel: "+Owner.Name+" "+Owner.Surname+" data urodzenia: "+Owner.Birth.ToShortDateString();
        }
        
    }
}