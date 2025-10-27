var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// permet d'associer des routes (endpoints) à une fonction
app.MapControllers();


app.Run();

