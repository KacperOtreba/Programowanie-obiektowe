﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zwierzęta_zarządzanie.Properties;

namespace Zwierzęta_zarządzanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Burek");
            Console.WriteLine(a1.Describe());
            a1.BirthDate = new DateTime(2018,2,20);
            a1.ShowAge();

            Animal a2 = new Animal("Mruczek", new DateTime(2020, 1, 24));
            Console.WriteLine(a2.Describe());
            a2.ShowAge();

            Animal a3 = new Animal("Azor", new DateTime(2021, 1, 24), true);
            Console.WriteLine(a3.Describe());
            a3.ShowAge();

            Animal a4 = new Animal("Papug", new DateTime(2023, 1, 24), false, Kind.Ptak);
            Console.WriteLine(a4.Describe());
            a4.ShowAge();

            ////////////////////////////////////////////////////////////////////////////////////////


            //lista zwierząt
            List<Animal> animals = new List<Animal>();


            //menu


            ShowMainMenu(animals);
            Console.ReadKey();
        }

        static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();

            //opcje
            Console.WriteLine("Witaj w programie to zarządzania zwierzętami!");
            Console.WriteLine("1. Dodaj zwierzę");
            Console.WriteLine("2. Pokaż listę zwierząt");
            Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
            Console.WriteLine("4. Usuń zwierzę");
            Console.WriteLine("5. Zakończ program\n");

            Console.WriteLine("Wybierz opcję");

            //wybór urzytkownika
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddNewAnimal(animals);
                    break;
                case "2":
                    ShowAnimalList(animals);
                    break;
                case "3":
                    ShowAnimalDetails(animals);
                    break;
                case "4":
                    DeleteAnimal(animals);
                    break;
                case "5":
                    Console.WriteLine("Dziekujemy za skorzystanie z programu.");
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja, nacisnij dowolny klawisz by spróbować ponownie.");
                    Console.ReadKey();
                    ShowMainMenu(animals);
                    break;
            }
        }

        private static void DeleteAnimal(List<Animal> animals)
        {
            
        }

        private static void ShowAnimalDetails(List<Animal> animals)
        {
            
        }

        private static void ShowAnimalList(List<Animal> animals)
        {
            
        }

        private static void AddNewAnimal(List<Animal> animals)
        {
            Console.Clear();
            System.Console.Write("Podaj nazwę zwierzęcia: ");
            string name = Console.ReadLine();

            System.Console.Write("Podaj datę urodzenia zwierzęcia (format RMD): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Czy zwierze jest ssakiem? (tak/nie): ");
            bool isMammal = Console.ReadLine().ToLower() == "tak";

            System.Console.Write("Podaj rodzaj zwierzęcia (Ptak, Gad, Płaz, Ssak, Ryba): ");
            Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());
            Console.WriteLine(kind); // jak podamy wartość 2 to wyjdzie Gad

            // utworzenia obiektu klasy Animal z podanymi danymi
            Animal animal = new Animal(name, birthDate, isMammal, kind);

            // dodanie obiektu do list zwierząt (animals)
            animals.Add(animal);

            // wyświetlenie potwierdzenia dodania zwierzęcia
            System.Console.WriteLine("\nDodano nowe zwierzę: "+ animal.Name);
            System.Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do menu głównego\n");
            Console.ReadKey();
            ShowMainMenu(animals);
        }
    }
}

#region zadanie
/*
             Zadanie: Napisz program w języku C#, który będzie umożliwiał zarządzanie listą zwierząt. Program powinien spełniać następujące wymagania.
            Każde zwierzę powinno mieć następujące właściwości: nazwę, datę urodzenia, informację czy jest ssakiem i rodzaj (ptak, ryba, gad, płaz lub ssak).
            Program powinien umożliwiać dodawanie nowych zwierząt do listy, podając ich właściwości od użytkownika.
            Program powinien umożliwiać wyświetlanie listy zwierząt z ich numerami i nazwami.
            Program powinien umożliwiać wyświetlanie szczegółów o wybranym zwierzęciu, takich jak opis, wiek i rodzaj.
            Program powinien umożliwiać usuwanie wszystkich lub pojedynczego zwierzęcia z listy.
            Program powinien mieć menu główne z opcjami do wyboru przez użytkownika.
            Program powinien być napisany zgodnie z konwencją nazewnictwa i formatowania kodu w C#.
            Wskazówki:

            Użyj klasy Animal do reprezentowania zwierzęcia i zdefiniuj jej właściwości, konstruktory i metody.
            Użyj typu wyliczeniowego Kind do reprezentowania rodzaju zwierzęcia i zdefiniuj jego wartości.
            Użyj listy generycznej List<Animal> do przechowywania zwierząt i korzystaj z jej metod do dodawania, usuwania i wyświetlania elementów.
            Użyj klasy Console i jej metod do komunikacji z użytkownikiem i obsługi wejścia i wyjścia.
            Użyj instrukcji switch lub if do obsługi różnych opcji menu i wywoływania odpowiednich metod.
            Użyj klasy DateTime i jej metod do przechowywania i obliczania daty urodzenia i wieku zwierzęcia
*/
#endregion