using Microsoft.EntityFrameworkCore;
using Calculadora.Dominio.Entidades;

namespace Calculadora.Infraestructura.Contexto
{
    public class CalculadoraDbContext : DbContext
    {
        public CalculadoraDbContext(DbContextOptions<CalculadoraDbContext> options) : base(options) { }

        public DbSet<RegistroCalculo> Registros { get; set; }
    }
}
