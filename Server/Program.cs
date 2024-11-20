using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using AstrologyAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados usando a string de conexão do appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AstrologyDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
