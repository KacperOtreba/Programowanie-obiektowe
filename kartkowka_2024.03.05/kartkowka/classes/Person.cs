namespace kartkowka.classes{

internal class Person
{
    public string Name{get; set;}
    public string Surname{get; set;}
    public DateTime Birth{get; set;}
    public string[] kids_names{get; set;}


    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string GetKidsNames()
    {
        return string.Join(", ", kids_names);
    }
}
}