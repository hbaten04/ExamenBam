using BAM.APLICATION.Services;
using BAM.DOMAIN.Interfaces.Repository;
using BAM.DOMAIN.Models;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using BAM.INFRASTRUCTURE.DATA.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddScoped<IRepository<Vehiculo, Guid>, BamRepository>();
builder.Services.AddScoped<IRepository<Cotizacion, Guid>, CotizacionRepository>();
builder.Services.AddScoped<IRepository<Marca, Guid>, MarcaRepository>();
builder.Services.AddScoped<IRepository<TipoVehiculo, Guid>, TipoVehiculoRepository>();

builder.Services.AddDbContext<BAMContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("Connection"));
});

builder.Services.AddScoped<VehiculoService>();
builder.Services.AddScoped<CotizacionService>();
builder.Services.AddScoped<MarcaService>();
builder.Services.AddScoped<TipoVehiculoService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
