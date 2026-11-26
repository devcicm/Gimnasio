using Gimnasio.API.Application;
using Gimnasio.API.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configuración por máquina (no versionada): permite que cada entorno
// (máquina del propietario, máquina de un colaborador, servidor) defina su
// propia cadena de conexión y nivel de compatibilidad sin editar el repo.
// Ver appsettings.local.example.json y docs/base-datos/02-retrocompatibilidad-entornos.md
builder.Configuration.AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: false);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion de Dependencias
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
