using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.DTOs
{
    public class ProveedorDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public string Ciudad { get; set; }
    }
}