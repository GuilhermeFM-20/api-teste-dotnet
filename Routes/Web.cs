using Api_teste.Data;
using Api_teste.Models;
using Api_teste.Requests;
using Microsoft.EntityFrameworkCore;

namespace Api_teste.Routes;

public static class WebRoutes
{
    public static void MapRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person/");

        route.MapPost("",
            async (PersonRequest request, PersonContext context) =>
            {
                var person = new Person(request.name,request.document);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            }
        );
        route.MapGet("",
            async (PersonContext context) =>
            {
                var people = await context.People.ToListAsync();
                
                return Results.Ok(people);
            }
        );
        route.MapPut("{id:guid}",
            async (Guid id, PersonRequest request,  PersonContext context) =>
            {
                var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);
                if (person is null){
                    return Results.NotFound();
                }
                
                person.Name = request.name;
                person.Document = request.document;
                
                await context.SaveChangesAsync();
                
                return Results.Ok(person);
            }
        );
    }
}