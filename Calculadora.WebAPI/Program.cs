using Calculadora.Aplicacion.Interfaces;
using Calculadora.Aplicacion.Servicios;
using Calculadora.Dominio.Interfaces;
using Calculadora.Infraestructura.Contexto;
using Calculadora.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar CORS para permitir requests desde el frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.WithOrigins("https://localhost:7054", "http://localhost:5264", "https://localhost:7054", "http://localhost:5264")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// --- Configuración de la Persistencia (Infraestructura) ---
// Configurar DbContext con SQLite
builder.Services.AddDbContext<CalculadoraDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=Calculadora.db"));

// Registrar el Repositorio
builder.Services.AddScoped<IRegistroRepository, RegistroRepository>();

// --- Configuración de la Lógica (Aplicación) ---
// Registrar el Servicio
builder.Services.AddScoped<IRegistroService, RegistroService>();

var app = builder.Build();

// --- Asegurar que la base de datos se cree al iniciar (Buena práctica) ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<CalculadoraDbContext>();
    // Esto crea la base de datos y el esquema si no existen.
    context.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar CORS antes de Authorization
app.UseCors("AllowBlazorClient");

app.UseAuthorization();
app.MapControllers();
app.Run();