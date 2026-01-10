namespace Eventos360.Shared.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin, Cliente, Proveedor
        public DateTime FechaRegistro { get; set; }
    }
}