namespace Eventos360.Shared.Entities
{
    public class RedesSociales
    {
        public Guid Id { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? YouTube { get; set; }
        public string? TikTok { get; set; }
        public Proveedor Proveedor { get; set; } = null!;
        public Guid ProveedorId { get; set; }
    }
}