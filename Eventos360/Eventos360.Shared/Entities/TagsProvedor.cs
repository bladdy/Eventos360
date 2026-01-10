using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.Entities
{
    public class TagsProvedor
    {
        public Guid Id { get; set; }
        public Guid ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
        public Guid TagId { get; set; }
        public Tags Tag { get; set; }
    }
}