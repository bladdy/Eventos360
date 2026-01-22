using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos360.Shared.Entities
{
    public class Proveedor
    {
        //public Guid Id { get; set; }
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Stand { get; set; }
        public string ImagenBannerUrl { get; set; }
        public decimal? PrecioMinimo { get; set; }
        public decimal? PrecioMaximo { get; set; }
        public string UrlSitioWeb { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string WhatsApp { get; set; }
        public string SitioWeb { get; set; }
        public string ImagenUrl { get; set; }
        public RedesSociales? RedesSociales { get; set; }
        public bool Activo { get; set; }
        public ICollection<TagsProvedor> TagsProvedors { get; set; } = new List<TagsProvedor>();
        public Categoria Categoria { get; set; }

        //public Guid CategoriaId { get; set; }
        public int CategoriaId { get; set; }

        public ICollection<ImagenProveedor> Galeria { get; set; } = new List<ImagenProveedor>();
        public ICollection<Resena> Resenas { get; set; } = new List<Resena>();
        public DateTime FechaCreacion { get; set; }
        public ICollection<Productos> Productos { get; set; } = new List<Productos>();
        public ICollection<Horarios> Horarios { get; set; } = new List<Horarios>();
    }
}