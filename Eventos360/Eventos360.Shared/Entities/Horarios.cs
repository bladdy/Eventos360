namespace Eventos360.Shared.Entities
{
    public class Horarios
    {
        public Guid Id { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraApertura { get; set; }
        public TimeSpan HoraCierre { get; set; }
        public Proveedor Proveedor { get; set; } = null!;
        public Guid ProveedorId { get; set; }
    }
}