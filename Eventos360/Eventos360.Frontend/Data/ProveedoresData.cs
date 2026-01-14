using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Eventos360.Frontend.Data
{
    public static class ProveedoresData
    {
        public static List<Proveedor> Todos => new()
        {
            LuzEnfoqueStudio,
            AndreiPerezWeddings,
            AndreiPerezWeddings,
            BeatWaveProductions,
            HaciendaLosEncinos
        };

        public static List<Proveedor> TopPorCategoria(int categoriaId, int take = 10)
        {
            return Todos
                .Where(p => p.Activo && p.CategoriaId == categoriaId)
                .OrderByDescending(p => p.Reseñas.Any()
                    ? p.Reseñas.Average(r => r.Calificacion)
                    : 0)
                .ThenByDescending(p => p.FechaCreacion)
                .Take(take)
                .ToList();
        }

        public static readonly Proveedor AndreiPerezWeddings = new()
        {
            Id = 1,
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
            Activo = true,

            CategoriaId = CategoriasData.FotografiaVideo.Id,
            Categoria = CategoriasData.FotografiaVideo,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Fotografia.Id, Tag = TagsData.Fotografia },
                new() { TagId = TagsData.Video.Id, Tag = TagsData.Video },
                new() { TagId = TagsData.Boda.Id, Tag = TagsData.Boda }
            },

            Horarios = new List<Horarios>
            {
                new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(10,0,0), HoraCierre = new(18,0,0) },
                new() { DiaSemana = "Sábado", HoraApertura = new(10,0,0), HoraCierre = new(16,0,0) },
                new() { DiaSemana = "Domingo", HoraApertura = new(11,0,0), HoraCierre = new(16,0,0) }
            },
            Galeria = new List<ImagenProveedor>
            {
                new() { Url = "/imagenes/categorias/fotografia.jpg" },
                new() { Url = "/imagenes/categorias/fotografia.jpg" },
                new() { Url = "/imagenes/categorias/fotografia.jpg" }
            },
            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/andreiperezweddings",
                Instagram = "https://instagram.com/andreiperezweddings",
                Twitter = "https://twitter.com/andreiperezwed",
                YouTube = "https://youtube.com/andreiperezweddings"
            },
            Productos = new List<Productos>
            {
                new()
                {
                    Id = 1,
                    Nombre = "Paquete Básico",
                    Descripcion = "Cobertura de 6 horas + edición profesional",
                    Precio = 15000,
                    ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                    Activo = true,
                    Destacado = true
                },
                new()
                {
                    Id = 2,
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
                new() { Id = 1, Calificacion = 5, Comentario = "Excelente trabajo.", FechaCreacion = DateTime.Now.AddDays(-10) },
                new() { Id = 2, Calificacion = 4, Comentario = "Muy profesionales.", FechaCreacion = DateTime.Now.AddDays(-6) }
            }
        };

        public static readonly Proveedor LuzEnfoqueStudio = new()
        {
            Id = 2,
            Nombre = "Luz & Enfoque Studio",
            Descripcion = "Fotografía artística y profesional para bodas y eventos sociales.",
            Stand = "STAND A-01",

            ImagenBannerUrl = "/imagenes/categorias/fotografia-categoria.jpg",
            ImagenUrl = "/imagenes/categorias/fotografia.jpg",

            PrecioMinimo = 12000,
            PrecioMaximo = 38000,

            Ciudad = "Ciudad de México",
            Estado = "CDMX",
            Direccion = "Roma Norte",

            Telefono = "8180001122",
            WhatsApp = "https://wa.me/528180001122",

            UrlSitioWeb = "https://andreiperezweddings.com",
            SitioWeb = "https://andreiperezweddings.com",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.FotografiaVideo.Id,
            Categoria = CategoriasData.FotografiaVideo,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Fotografia.Id, Tag = TagsData.Fotografia },
                new() { TagId = TagsData.Video.Id, Tag = TagsData.Video },
                new() { TagId = TagsData.Boda.Id, Tag = TagsData.Boda }
            },

            Horarios = new List<Horarios>
            {
                new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(10,0,0), HoraCierre = new(18,0,0) },
                new() { DiaSemana = "Sábado", HoraApertura = new(10,0,0), HoraCierre = new(16,0,0) },
                new() { DiaSemana = "Domingo", HoraApertura = new(11,0,0), HoraCierre = new(16,0,0) }
            },
            Galeria = new List<ImagenProveedor>
            {
                new() { Url = "/imagenes/categorias/fotografia.jpg" },
                new() { Url = "/imagenes/categorias/fotografia.jpg" },
                new() { Url = "/imagenes/categorias/fotografia.jpg" }
            },
            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/andreiperezweddings",
                Instagram = "https://instagram.com/andreiperezweddings",
                Twitter = "https://twitter.com/andreiperezwed",
                YouTube = "https://youtube.com/andreiperezweddings"
            },
            Productos = new List<Productos>
            {
                new()
                {
                    Id = 1,
                    Nombre = "Paquete Básico",
                    Descripcion = "Cobertura de 6 horas + edición profesional",
                    Precio = 15000,
                    ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                    Activo = true,
                    Destacado = true
                },
                new()
                {
                    Id = 2,
                    Nombre = "Paquete Black",
                    Descripcion = "Cobertura completa + drone + álbum",
                    Precio = 45000,
                    ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                    Activo = true,
                    Destacado = true
                }
            },

            Reseñas = new List<Resena>
            {
                new() { Id = 1, Calificacion = 5, Comentario = "Excelente trabajo.", FechaCreacion = DateTime.Now.AddDays(-10) },
                new() { Id = 2, Calificacion = 4, Comentario = "Muy profesionales.", FechaCreacion = DateTime.Now.AddDays(-6) }
            }
        };

        public static readonly Proveedor BeatWaveProductions = new()
        {
            Id = 3,
            Nombre = "BeatWave Productions",
            Descripcion = "DJ profesional y música en vivo para bodas, fiestas y eventos corporativos.",
            Stand = "STAND B-05",

            ImagenBannerUrl = "/imagenes/categorias/DJ.jpg",
            ImagenUrl = "/imagenes/categorias/DJ.jpg",

            PrecioMinimo = 8000,
            PrecioMaximo = 55000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",
            Direccion = "San Pedro Garza García",

            Telefono = "8185552233",
            WhatsApp = "https://wa.me/528185552233",

            UrlSitioWeb = "https://beatwaveproductions.mx",
            SitioWeb = "https://beatwaveproductions.mx",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.DjMusica.Id,
            Categoria = CategoriasData.DjMusica,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Musica.Id, Tag = TagsData.Musica },
                new() { TagId = TagsData.MusicaEnvivo.Id, Tag = TagsData.MusicaEnvivo },
                new() { TagId = TagsData.Boda.Id, Tag = TagsData.Boda }
            },

            Horarios = new List<Horarios>
            {
                new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(9,0,0), HoraCierre = new(19,0,0) },
                new() { DiaSemana = "Sábado", HoraApertura = new(10,0,0), HoraCierre = new(18,0,0) }
            },

            Galeria = new List<ImagenProveedor>
            {
                new() { Url = "/imagenes/categorias/DJ.jpg" },
                new() { Url = "/imagenes/categorias/DJ.jpg" },
                new() { Url = "/imagenes/categorias/DJ.jpg" }
            },

            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/beatwaveproductions",
                Instagram = "https://instagram.com/beatwaveproductions",
                YouTube = "https://youtube.com/@beatwaveproductions"
            },

            Productos = new List<Productos>
            {
                new()
                {
                    Id = 3,
                    Nombre = "DJ Básico",
                    Descripcion = "DJ + audio profesional por 4 horas",
                    Precio = 12000,
                    ImagenUrl = "/imagenes/categorias/DJ.jpg",
                    Activo = true,
                    Destacado = true
                },
                new()
                {
                    Id = 4,
                    Nombre = "DJ + Banda en Vivo",
                    Descripcion = "DJ + grupo musical + iluminación",
                    Precio = 48000,
                    ImagenUrl = "/imagenes/categorias/DJ.jpg",
                    Activo = true,
                    Destacado = true
                }
            },

            Reseñas = new List<Resena>
            {
                new() { Id = 3, Calificacion = 5, Comentario = "Ambiente increíble toda la noche.", FechaCreacion = DateTime.Now.AddDays(-8) },
                new() { Id = 4, Calificacion = 4, Comentario = "Excelente música y sonido.", FechaCreacion = DateTime.Now.AddDays(-4) }
            }
        };

        public static readonly Proveedor HaciendaLosEncinos = new()
        {
            Id = 4,
            Nombre = "Hacienda Los Encinos",
            Descripcion = "Hacienda exclusiva para bodas y eventos sociales rodeada de naturaleza.",
            Stand = "STAND C-02",

            ImagenBannerUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
            ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",

            PrecioMinimo = 45000,
            PrecioMaximo = 180000,

            Ciudad = "Querétaro",
            Estado = "Querétaro",
            Direccion = "Carretera Querétaro-Tequisquiapan Km 18",

            Telefono = "4421238899",
            WhatsApp = "https://wa.me/524421238899",

            UrlSitioWeb = "https://haciendalosencinos.mx",
            SitioWeb = "https://haciendalosencinos.mx",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.SalonesLocaciones.Id,
            Categoria = CategoriasData.SalonesLocaciones,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Sociales.Id, Tag = TagsData.Sociales },
                new() { TagId = TagsData.Boda.Id, Tag = TagsData.Boda },
                new() { TagId = TagsData.Salon.Id, Tag = TagsData.Salon }
            },

            Horarios = new List<Horarios>
            {
                new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(9,0,0), HoraCierre = new(18,0,0) },
                new() { DiaSemana = "Sábado", HoraApertura = new(9,0,0), HoraCierre = new(20,0,0) }
            },

            Galeria = new List<ImagenProveedor>
            {
                new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" },
                new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" },
                new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" }
            },

            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/haciendalosencinos",
                Instagram = "https://instagram.com/haciendalosencinos"
            },

            Productos = new List<Productos>
            {
                new()
                {
                    Id = 5,
                    Nombre = "Renta de Salón",
                    Descripcion = "Uso de la hacienda por 8 horas",
                    Precio = 65000,
                    ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
                    Activo = true,
                    Destacado = true
                },
                new()
                {
                    Id = 6,
                    Nombre = "Paquete Todo Incluido",
                    Descripcion = "Salón + mobiliario + coordinación",
                    Precio = 150000,
                    ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
                    Activo = true,
                    Destacado = true
                }
            },

            Reseñas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };
    }
}