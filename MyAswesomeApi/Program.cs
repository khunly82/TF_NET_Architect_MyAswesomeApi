var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors(b => b.AddDefaultPolicy(o =>
{
    o.AllowAnyOrigin();
    //o.WithOrigins("https://google.be", "", "");
    o.AllowAnyMethod();
    o.AllowAnyHeader();
}));

var app = builder.Build();

app.UseCors();

// permet d'associer des routes (endpoints) à une fonction
app.MapControllers();


app.Run();

// commentaire bidon

