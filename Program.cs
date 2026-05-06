using Api_teste.Data;
using Api_teste.Routes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração correta do DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<PersonContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

var app = builder.Build();

// Swagger (somente dev)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Rotas
WebRoutes.MapRoutes(app);

// HTTPS
app.UseHttpsRedirection();

app.Run();