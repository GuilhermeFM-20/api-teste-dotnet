namespace Api_teste.Models;

public class Person
{
    public Person(string name, string document)
    {
        Name = name;
        Document = document;
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Document { get; set; }
}