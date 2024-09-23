/*
Temat zadania: System Zarządzania Biblioteką
Opis zadania:
Stwórz aplikację konsolową w języku C#, która będzie symulować system zarządzania biblioteką. Aplikacja powinna umożliwiać zarządzanie książkami, autorami oraz wypożyczeniami. W projekcie należy wykorzystać dziedziczenie, konstruktory oraz kompozycję.
Wymagania funkcjonalne:
1.	Klasa Person:
o	Pola: FirstName, LastName.
o	Konstruktor: inicjalizujący pola FirstName i LastName.
2.	Klasa Author (dziedziczy po klasie Person):
o	Pola: BooksList (lista książek napisanych przez autora).
o	Konstruktor: inicjalizujący pola FirstName, LastName oraz pustą listę książek.
o	Metoda: AddBook(Book book) - dodaje książkę do listy książek autora.
3.	Klasa Book:
o	Pola: Title, Author (obiekt klasy Author), PublicationYear.
o	Konstruktor: inicjalizujący pola Title, Author, PublicationYear.
4.	Klasa Reader (dziedziczy po klasie Person):
o	Pola: BorrowedBooksList (lista wypożyczonych książek).
o	Konstruktor: inicjalizujący pola FirstName, LastName oraz pustą listę wypożyczeń.
o	Metoda: BorrowBook(Book book) - dodaje książkę do listy wypożyczeń.
5.	Klasa Library:
o	Pola: BooksList (lista wszystkich książek w bibliotece), ReadersList (lista czytelników).
o	Konstruktor: inicjalizujący pustą listę książek i czytelników.
o	Metody:
	AddBook(Book book) - dodaje książkę do listy książek.
	AddReader(Reader reader) - dodaje czytelnika do listy czytelników.
	BorrowBook(Reader reader, Book book) - umożliwia wypożyczenie książki przez czytelnika.
*/
namespace lekcja_2024._09._23;

class Program
{
    public class Person
    {
    public string FirstName {get; set; }
    public string LastName { get; set; }
    public Person(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }
    }

    public class Author : Person
    {
    public List<Book> BookList { get; set; }
    public Author(string firstname, string lastname) : base(firstname, lastname)
    {
        BookList = new List<Book>();
    }
    public void AddBook(Book book)
    {
        BookList.Add(book);
    }
    }

    public class Book
    {
    public string Title { get; set; }
    public Author author { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, Author author, int publicationYear)
    {
        Title = title;
        this.author = author;
        PublicationYear = publicationYear;
    }
    }   

    public class Reader : Person
    {
    public List<Book> BorrowedBooksList { get; set; }

    public Reader(string firstname, string lastname) : base(firstname, lastname)
    {
        BorrowedBooksList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BorrowedBooksList.Add(book);
        System.Console.WriteLine($"Czytelnik {FirstName} {LastName} wypożyczył książkę: {book.Title}");
    }
    }
    static void Main(string[] args)
    {
        Author author = new Author("Adam", "Mickiewicz");
        Book book = new Book("Pan Tadeusz", author, 1834);
    }
}
