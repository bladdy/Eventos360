using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.Entities
{
    public class Resena
    {
        //public Guid Id { get; set; }
        //public Guid ProveedorId { get; set; }
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int Calificacion { get; set; } // 1–5
        public string Comentario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}