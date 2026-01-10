using Eventos360.Shared.DTOs;

namespace Eventos360.Frontend.Pages
{
    public partial class Home
    {
        private List<ProveedorDTO> Top10Proveedores;

        protected override void OnInitialized()
        {
            Top10Proveedores = ObtenerTop10Proveedores();
        }

        private List<ProveedorDTO> ObtenerTop10Proveedores()
        {
            return new List<ProveedorDTO>
            {
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Luz & Enfoque Studio",
        ImagenUrl = "/images/proveedores/proveedor-1.jpg",
        Ciudad = "Ciudad de México"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Momentos Eternos",
        ImagenUrl = "/images/proveedores/proveedor-2.jpg",
        Ciudad = "Guadalajara"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Flash Creativo",
        ImagenUrl = "/images/proveedores/proveedor-3.jpg",
        Ciudad = "Monterrey"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Recuerdos Premium",
        ImagenUrl = "/images/proveedores/proveedor-4.jpg",
        Ciudad = "Puebla"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Vision Wedding Films",
        ImagenUrl = "/images/proveedores/proveedor-5.jpg",
        Ciudad = "Querétaro"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Arte & Celebración",
        ImagenUrl = "/images/proveedores/proveedor-6.jpg",
        Ciudad = "Toluca"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Frame Perfecto",
        ImagenUrl = "/images/proveedores/proveedor-7.jpg",
        Ciudad = "Mérida"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Captura Única",
        ImagenUrl = "/images/proveedores/proveedor-8.jpg",
        Ciudad = "Cancún"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "StoryLove Films",
        ImagenUrl = "/images/proveedores/proveedor-9.jpg",
        Ciudad = "León"
    },
    new ProveedorDTO
    {
        Id = Guid.NewGuid(),
        Nombre = "Golden Day Studio",
        ImagenUrl = "/images/proveedores/proveedor-10.jpg",
        Ciudad = "Aguascalientes"
    }
};
        }
    }
}