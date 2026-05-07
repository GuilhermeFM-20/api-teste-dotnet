namespace Api_teste.Models;

public class Person : BaseEntity
{
    public Person(string name, string document)
    {
        Id = Guid.NewGuid();
        Name = name;
        Document = document;
        CreatedAt = DateTime.UtcNow;
    }

    public Guid Id { get; init; }

    public string Name { get; set; } = string.Empty;

    public string Document { get; set; } = string.Empty;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public void Update(string name, string document)
    {
        Name = name;
        Document = document;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Delete()
    {
        DeletedAt = DateTime.UtcNow;
    }
}