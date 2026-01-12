using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.Entities
{
    public class Productos
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        public bool Activo { get; set; }
        public bool Destacado { get; set; }
        public Guid ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}