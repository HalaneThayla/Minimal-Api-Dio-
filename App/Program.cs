using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(Options =>{
   Options.UseMySql(
    builder.Configuration.GetConnectionString("mysql"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
   );
});


var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "amd@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso");
    }
    else
        return Results.Unauthorized();

});


app.Run();

