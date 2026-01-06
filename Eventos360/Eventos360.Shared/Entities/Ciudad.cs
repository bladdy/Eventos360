using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.Entities
{
    public class Ciudad
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public List<Proveedor> Proveedores { get; set; }
    }

}
