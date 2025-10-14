namespace Calculadora.Dominio.Entidades
{
    public class RegistroCalculo
    {
        public int Id { get; set; }
        public string NombreDescriptivo { get; set; } = string.Empty;
        public decimal Resultado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
