using Microsoft.EntityFrameworkCore;
using SegundoParcial.Server.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexion = builder.Configuration.GetConnectionString("conexion");
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlite(conexion));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//LINEAS NUEVAS PARA ACTIVAR EL CORD
app.UseCors(options =>
{
    options.AllowAnyOrigin(); // Permitir solicitudes desde cualquier origen
    options.AllowAnyHeader(); // Permitir cualquier encabezado
    options.AllowAnyMethod(); // Permitir cualquier método HTTP
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
