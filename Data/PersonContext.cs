using Api_teste.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_teste.Data;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {}

    public DbSet<Person> People { get; set; }
}                           