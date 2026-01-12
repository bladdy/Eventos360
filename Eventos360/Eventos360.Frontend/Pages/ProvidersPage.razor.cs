using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Pages
{
    public partial class ProvidersPage
    {
        private Proveedor? selectedProveedor;

        private double PromedioCalificacion =>
        selectedProveedor.Reseñas.Any()
            ? Math.Round(selectedProveedor.Reseñas.Average(r => r.Calificacion), 1)
            : 0;

        //private Proveedor selectedProveedor;

        protected override void OnInitialized()
        {
            var categoria = new Categoria
            {
                Id = Guid.NewGuid(),
                Nombre = "Fotografía y Video",
                Descripcion = "Servicios profesionales para eventos",
                ImagenUrl = "/imagenes/categorias/fotografia-categoria.jpg"
            };

            var tagFoto = new Tags { Id = Guid.NewGuid(), Nombre = "Fotografía" };
            var tagVideo = new Tags { Id = Guid.NewGuid(), Nombre = "Video" };
            var tagBoda = new Tags { Id = Guid.NewGuid(), Nombre = "Boda" };

            selectedProveedor = new Proveedor
            {
                Id = Guid.NewGuid(),
                Nombre = "Andrei Pérez Weddings",
                Descripcion = "Capturamos los momentos más importantes de tu evento con un estilo cinematográfico, elegante y emocional.",
                Stand = "STAND B-23",
                ImagenBannerUrl = "/imagenes/categorias/fotografia-categoria.jpg",
                ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                PrecioMinimo = 15000,
                PrecioMaximo = 45000,
                Ciudad = "Monterrey",
                Estado = "Nuevo León",
                Direccion = "Av. Constitución 1234, Centro",
                Telefono = "8180001122",
                WhatsApp = "https://wa.me/528180001122",
                UrlSitioWeb = "https://andreiperezweddings.com",
                SitioWeb = "https://andreiperezweddings.com",
                FechaCreacion = DateTime.Now,

                Categoria = categoria,
                CategoriaId = categoria.Id,

                TagsProvedors = new List<TagsProvedor>
                {
                    new TagsProvedor { Tag = tagFoto },
                    new TagsProvedor { Tag = tagVideo },
                    new TagsProvedor { Tag = tagBoda }
                },

                Galeria = new List<ImagenProveedor>
                {
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" },
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" },
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" },
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" },
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" },
                    new ImagenProveedor { Url = "/imagenes/categorias/fotografia.jpg" }
                },
                Activo = true,
                RedesSociales = new RedesSociales
                {
                    Facebook = "https://facebook.com/andreiperezweddings",
                    Instagram = "https://instagram.com/andreiperezweddings",
                    Twitter = "https://twitter.com/andreiperezwed",
                    YouTube = "https://youtube.com/andreiperezweddings"
                },
                Horarios = new List<Horarios>
                {
                    new Horarios
                    {
                        DiaSemana = "Lunes a Viernes",
                        HoraApertura = new TimeSpan(10, 0, 0),
                        HoraCierre = new TimeSpan(18, 0, 0)
                    },
                    new Horarios
                    {
                        DiaSemana = "Sábado",
                        HoraApertura = new TimeSpan(10, 0, 0),
                        HoraCierre = new TimeSpan(16, 0, 0)
                    },
                    new Horarios
                    {
                        DiaSemana = "Domingo",
                        HoraApertura = new TimeSpan(11, 0, 0),
                        HoraCierre = new TimeSpan(16, 0, 0)
                    },
                    new Horarios
                    {
                        DiaSemana = "Festivos",
                        HoraApertura = new TimeSpan(11, 0, 0),
                        HoraCierre = new TimeSpan(15, 0, 0)
                    }
                },

                Productos = new List<Productos>
                {
                    new Productos
                    {
                        Nombre = "Paquete Básico",
                        Descripcion = "Cobertura de 6 horas + edición profesional",
                        Precio = 15000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    },
                    new Productos
                    {
                        Nombre = "Paquete Premium",
                        Descripcion = "Cobertura completa + drone + álbum",
                        Precio = 45000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    },
                    new Productos
                    {
                        Nombre = "Paquete Básico",
                        Descripcion = "Cobertura de 6 horas + edición profesional",
                        Precio = 15000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    },
                    new Productos
                    {
                        Nombre = "Paquete Premium",
                        Descripcion = "Cobertura completa + drone + álbum",
                        Precio = 45000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    },
                    new Productos
                    {
                        Nombre = "Paquete Básico",
                        Descripcion = "Cobertura de 6 horas + edición profesional",
                        Precio = 15000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    },
                    new Productos
                    {
                        Nombre = "Paquete Premium",
                        Descripcion = "Cobertura completa + drone + álbum",
                        Precio = 45000,
                        ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                        Activo = true,
                        Destacado = true
                    }
                },

                Reseñas = new List<Resena>
                {
                    new Resena
                    {
                        Calificacion = 5,
                        Comentario = "Excelente trabajo, muy profesionales.",
                        FechaCreacion = DateTime.Now.AddDays(-10)
                    },
                    new Resena
                    {
                        Calificacion = 4,
                        Comentario = "Excelente trabajo, muy profesionales.",
                        FechaCreacion = DateTime.Now.AddDays(-6)
                    },
                    new Resena
                    {
                        Calificacion = 3,
                        Comentario = "Excelente trabajo, muy profesionales.",
                        FechaCreacion = DateTime.Now.AddDays(-3)
                    },
                    new Resena
                    {
                        Calificacion = 4,
                        Comentario = "Excelente trabajo, muy profesionales.",
                        FechaCreacion = DateTime.Now.AddDays(-9)
                    }
                }
            };
        }
    }
}