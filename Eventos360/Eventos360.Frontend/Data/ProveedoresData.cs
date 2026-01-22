using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Eventos360.Frontend.Data
{
    public static class ProveedoresData
    {
        public static List<Proveedor> Todos =>
        [
            LuzEnfoqueStudio,
            AndreiPerezWeddings,
            AndreiPerezWeddings,
            BeatWaveProductions,
            HaciendaLosEncinos,
            Invboxv,
            EventiaPlanner,
            PlaneacionEventos,
            BanquetesCatering,
            DeliciasBanquetes,
            BebidasBarras,
            Floreria,
            DecoracionEventos,
            TransporteEventoss,
            RecuerdosEventos,
            MusicaAnimacion,
            ShowsEspectaculos,
            MaquillajePeinado,
            VestuarioModa,
            DetallesRecuerdos,
            TransporteEventos

        ];

        public static List<Proveedor> TopPorCategoria(int categoriaId, int take = 10)
        {
            return Todos
                .Where(p => p.Activo && p.CategoriaId == categoriaId)
                .OrderByDescending(p =>
                    p.Resenas != null && p.Resenas.Any()
                        ? p.Resenas.Average(r => r.Calificacion)
                        : 0
                )
                .ThenByDescending(p => p.FechaCreacion)
                .Take(take)
                .ToList();
        }

        public static readonly Proveedor MusicaAnimacion = new()
        {
            Id = 12,
            Nombre = "Party Live",
            Descripcion = "Grupos musicales y animadores.",
            Stand = "MUSIC-07",

            ImagenBannerUrl = "/imagenes/categorias/musica.jpg",
            ImagenUrl = "/imagenes/Proveedores/musica.jpg",

            PrecioMinimo = 10000,
            PrecioMaximo = 60000,

            Ciudad = "Monclova",
            Estado = "Coahuila",

            Telefono = "8664455667",
            WhatsApp = "https://wa.me/528664455667",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.MusicaAnimacion.Id,
            Categoria = CategoriasData.MusicaAnimacion,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.MusicaEnVivo.Id, Tag = TagsData.MusicaEnVivo },
                new() { TagId = TagsData.DJ.Id, Tag = TagsData.DJ }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor TransporteEventos = new()
        {
            Id = 17,
            Nombre = "Event Transport VIP",
            Descripcion = "Transporte seguro y puntual para eventos.",
            Stand = "TRANS-01",

            ImagenBannerUrl = "/imagenes/categorias/transporte.jpg",
            ImagenUrl = "/imagenes/Proveedores/transporte.jpg",

            PrecioMinimo = 6000,
            PrecioMaximo = 30000,

            Ciudad = "Monclova",
            Estado = "Coahuila",

            Telefono = "8667788990",
            WhatsApp = "https://wa.me/528667788990",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.TransporteEventos.Id,
            Categoria = CategoriasData.TransporteEventos,

            TagsProvedors = new List<TagsProvedor>
    {
        new() { TagId = TagsData.Transporte.Id, Tag = TagsData.Transporte },
        new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor DetallesRecuerdos = new()
        {
            Id = 18,
            Nombre = "Detalles Únicos",
            Descripcion = "Recuerdos personalizados para eventos.",
            Stand = "DET-06",

            ImagenBannerUrl = "/imagenes/categorias/recuerdos.jpg",
            ImagenUrl = "/imagenes/Proveedores/recuerdos.jpg",

            PrecioMinimo = 2000,
            PrecioMaximo = 12000,

            Ciudad = "Saltillo",
            Estado = "Coahuila",

            Telefono = "8448899001",
            WhatsApp = "https://wa.me/528448899001",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.DetallesRecuerdos.Id,
            Categoria = CategoriasData.DetallesRecuerdos,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Souvenirs.Id, Tag = TagsData.Souvenirs },
                new() { TagId = TagsData.Recuerdos.Id, Tag = TagsData.Recuerdos }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor MaquillajePeinado = new()
        {
            Id = 16,
            Nombre = "Beauty Pro",
            Descripcion = "Maquillaje profesional y peinado.",
            Stand = "BEAUTY-02",

            ImagenBannerUrl = "/imagenes/categorias/maquillaje.jpg",
            ImagenUrl = "/imagenes/Proveedores/maquillaje.jpg",

            PrecioMinimo = 2500,
            PrecioMaximo = 15000,

            Ciudad = "Torreón",
            Estado = "Coahuila",

            Telefono = "8716677889",
            WhatsApp = "https://wa.me/528716677889",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.MaquillajePeinado.Id,
            Categoria = CategoriasData.MaquillajePeinado,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Maquillaje.Id, Tag = TagsData.Maquillaje },
                new() { TagId = TagsData.Peinado.Id, Tag = TagsData.Peinado }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor VestuarioModa = new()
        {
            Id = 15,
            Nombre = "Glam Dress",
            Descripcion = "Renta y venta de vestuario para eventos.",
            Stand = "MODA-04",

            ImagenBannerUrl = "/imagenes/categorias/moda.jpg",
            ImagenUrl = "/imagenes/Proveedores/moda.jpg",

            PrecioMinimo = 3000,
            PrecioMaximo = 50000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",

            Telefono = "8184455667",
            WhatsApp = "https://wa.me/528184455667",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.VestuarioModa.Id,
            Categoria = CategoriasData.VestuarioModa,

            TagsProvedors = new List<TagsProvedor>
                {
                    new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas },
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor ShowsEspectaculos = new()
        {
            Id = 13,
            Nombre = "ShowTime MX",
            Descripcion = "Shows, artistas y espectáculos visuales.",
            Stand = "SHOW-03",

            ImagenBannerUrl = "/imagenes/categorias/shows.jpg",
            ImagenUrl = "/imagenes/Proveedores/shows.jpg",

            PrecioMinimo = 7000,
            PrecioMaximo = 50000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",

            Telefono = "8189988776",
            WhatsApp = "https://wa.me/528189988776",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.ShowsEspectaculos.Id,
            Categoria = CategoriasData.ShowsEspectaculos,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Mariachi.Id, Tag = TagsData.Mariachi },
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor Floreria = new()
        {
            Id = 11,
            Nombre = "Floral Moments",
            Descripcion = "Diseño floral para eventos exclusivos.",
            Stand = "FLOR-05",

            ImagenBannerUrl = "/imagenes/categorias/floreria.jpg",
            ImagenUrl = "/imagenes/Proveedores/floreria.jpg",

            PrecioMinimo = 5000,
            PrecioMaximo = 40000,

            Ciudad = "Torreón",
            Estado = "Coahuila",

            Telefono = "8713344556",
            WhatsApp = "https://wa.me/528713344556",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.Floreria.Id,
            Categoria = CategoriasData.Floreria,

            TagsProvedors = new List<TagsProvedor>
    {
        new() { TagId = TagsData.FloreriaEventos.Id, Tag = TagsData.FloreriaEventos },
        new() { TagId = TagsData.CentrosMesa.Id, Tag = TagsData.CentrosMesa }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor BebidasBarras = new()
        {
            Id = 10,
            Nombre = "Bar Experience",
            Descripcion = "Barras móviles premium y coctelería.",
            Stand = "BAR-02",

            ImagenBannerUrl = "/imagenes/categorias/barras.jpg",
            ImagenUrl = "/imagenes/Proveedores/barra.jpg",

            PrecioMinimo = 8000,
            PrecioMaximo = 35000,

            Ciudad = "Saltillo",
            Estado = "Coahuila",

            Telefono = "8442233445",
            WhatsApp = "https://wa.me/528442233445",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.BebidasBarras.Id,
            Categoria = CategoriasData.BebidasBarras,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.BarraLibre.Id, Tag = TagsData.BarraLibre },
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor PlaneacionEventos = new()
        {
            Id = 2,
            Nombre = "Elite Event Planner",
            Descripcion = "Planeación integral de eventos sociales y corporativos.",
            Stand = "STAND A-12",

            ImagenBannerUrl = "/imagenes/categorias/planeacion-eventos.jpg",
            ImagenUrl = "/imagenes/Proveedores/planeacion.jpg",

            PrecioMinimo = 20000,
            PrecioMaximo = 80000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",
            Direccion = "Av. Constitución 1200",

            Telefono = "8112345678",
            WhatsApp = "https://wa.me/528112345678",

            UrlSitioWeb = "https://eliteeventplanner.mx",
            SitioWeb = "https://eliteeventplanner.mx",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.PlaneacionEventos.Id,
            Categoria = CategoriasData.PlaneacionEventos,

            TagsProvedors = new List<TagsProvedor>
    {
        new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas },
        new() { TagId = TagsData.EventosCorporativos.Id, Tag = TagsData.EventosCorporativos },
        new() { TagId = TagsData.Coordinacion.Id, Tag = TagsData.Coordinacion }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor DecoracionEventos = new()
        {
            Id = 6,
            Nombre = "Dream Decor",
            Descripcion = "Decoración temática y personalizada.",
            Stand = "STAND G-11",

            ImagenBannerUrl = "/imagenes/categorias/decoracion.jpg",
            ImagenUrl = "/imagenes/Proveedores/decoracion.jpg",

            PrecioMinimo = 7000,
            PrecioMaximo = 40000,

            Ciudad = "Monclova",
            Estado = "Coahuila",

            Telefono = "8663344556",
            WhatsApp = "https://wa.me/528663344556",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.DecoracionAmbientacion.Id,
            Categoria = CategoriasData.DecoracionAmbientacion,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Decoracion.Id, Tag = TagsData.Decoracion },
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor BanquetesCatering = new()
        {
            Id = 3,
            Nombre = "Delizia Catering",
            Descripcion = "Banquetes gourmet para todo tipo de eventos.",
            Stand = "STAND C-05",

            ImagenBannerUrl = "/imagenes/categorias/banquetes.jpg",
            ImagenUrl = "/imagenes/Proveedores/catering.jpg",

            PrecioMinimo = 12000,
            PrecioMaximo = 60000,

            Ciudad = "Saltillo",
            Estado = "Coahuila",
            Direccion = "Blvd. Venustiano Carranza",

            Telefono = "8441239988",
            WhatsApp = "https://wa.me/528441239988",

            UrlSitioWeb = "https://deliziacatering.mx",
            SitioWeb = "https://deliziacatering.mx",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.BanquetesCatering.Id,
            Categoria = CategoriasData.BanquetesCatering,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Buffet.Id, Tag = TagsData.Buffet },
                new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor TransporteEventoss = new()
        {
            Id = 7,
            Nombre = "Luxury Transport",
            Descripcion = "Transporte ejecutivo y limusinas para eventos.",
            Stand = "STAND H-02",

            ImagenBannerUrl = "/imagenes/categorias/transporte.jpg",
            ImagenUrl = "/imagenes/Proveedores/transporte.jpg",

            PrecioMinimo = 5000,
            PrecioMaximo = 25000,

            Ciudad = "Saltillo",
            Estado = "Coahuila",

            Telefono = "8449988771",
            WhatsApp = "https://wa.me/528449988771",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.TransporteEventos.Id,
            Categoria = CategoriasData.TransporteEventos,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Transporte.Id, Tag = TagsData.Transporte },
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor RecuerdosEventos = new()
        {
            Id = 8,
            Nombre = "Recuerdos Mágicos",
            Descripcion = "Recuerdos personalizados para eventos.",
            Stand = "STAND J-06",

            ImagenBannerUrl = "/imagenes/categorias/recuerdos.jpg",
            ImagenUrl = "/imagenes/Proveedores/recuerdos.jpg",

            PrecioMinimo = 3000,
            PrecioMaximo = 15000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",

            Telefono = "8116677889",
            WhatsApp = "https://wa.me/528116677889",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.DetallesRecuerdos.Id,
            Categoria = CategoriasData.DetallesRecuerdos,

            TagsProvedors = new List<TagsProvedor>
    {
        new() { TagId = TagsData.Recuerdos.Id, Tag = TagsData.Recuerdos },
        new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };

        public static readonly Proveedor DeliciasBanquetes = new()
        {
            Id = 3,
            Nombre = "Delicias Banquetes & Catering",
            Descripcion = "Servicio profesional de banquetes y catering para bodas, XV años y eventos empresariales. Menús personalizados con ingredientes de alta calidad.",
            Stand = "STAND C-08",

            ImagenBannerUrl = "/imagenes/categorias/Banquetes.jpg",
            ImagenUrl = "/imagenes/Proveedores/banquetes-catering.jpg",

            PrecioMinimo = 18000,
            PrecioMaximo = 120000,

            Ciudad = "Saltillo",
            Estado = "Coahuila",
            Direccion = "Blvd. Venustiano Carranza 2450",

            Telefono = "8441234567",
            WhatsApp = "https://wa.me/528441234567",

            UrlSitioWeb = "https://deliciasbanquetes.com/",
            SitioWeb = "https://deliciasbanquetes.com/",

            FechaCreacion = DateTime.Now,
            Activo = true,

            // 🔹 CATEGORÍA
            CategoriaId = CategoriasData.BanquetesCatering.Id,
            Categoria = CategoriasData.BanquetesCatering,

            // 🔹 TAGS DE BANQUETES Y CATERING
            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.BanqueteFormal.Id, Tag = TagsData.BanqueteFormal },
                new() { TagId = TagsData.CateringBodas.Id, Tag = TagsData.CateringBodas },
                new() { TagId = TagsData.Buffet.Id, Tag = TagsData.Buffet },
                new() { TagId = TagsData.ServicioMeseros.Id, Tag = TagsData.ServicioMeseros },
                new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas },
                new() { TagId = TagsData.XVAnos.Id, Tag = TagsData.XVAnos }
            },

            Horarios = new List<Horarios>
    {
        new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(9,0,0), HoraCierre = new(18,0,0) },
        new() { DiaSemana = "Sábado", HoraApertura = new(9,0,0), HoraCierre = new(15,0,0) }
    },

            Galeria = new List<ImagenProveedor>
    {
        new() { Url = "/imagenes/categorias/Banquetes.jpg" },
        new() { Url = "/imagenes/categorias/Banquetes.jpg" },
        new() { Url = "/imagenes/categorias/Banquetes.jpg" }
    },

            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/deliciasbanquetes",
                Instagram = "https://instagram.com/deliciasbanquetes",
                Twitter = "https://twitter.com/deliciasbanq",
                YouTube = "https://youtube.com/deliciasbanquetes"
            },

            Productos = new List<Productos>
    {
        new()
        {
            Id = 1,
            Nombre = "Paquete Buffet Tradicional",
            Descripcion = "Buffet completo con 3 tiempos, bebidas y servicio de meseros.",
            Precio = 18000,
            ImagenUrl = "/imagenes/categorias/banquete1.jpg",
            Activo = true,
            Destacado = false
        },
        new()
        {
            Id = 2,
            Nombre = "Banquete Premium",
            Descripcion = "Banquete formal de 4 tiempos, barra de bebidas y montaje completo.",
            Precio = 120000,
            ImagenUrl = "/imagenes/categorias/banquete2.jpg",
            Activo = true,
            Destacado = true
        }
    },

            Resenas = new List<Resena>
    {
        new() { Id = 1, Calificacion = 5, Nombre = "Lucía", Comentario = "La comida estuvo espectacular y el servicio impecable.", FechaCreacion = DateTime.Now.AddDays(-20) },
        new() { Id = 2, Calificacion = 4, Nombre = "Roberto", Comentario = "Muy buena atención y excelente presentación.", FechaCreacion = DateTime.Now.AddDays(-12) }
    }
        };

        public static readonly Proveedor EventiaPlanner = new()
        {
            Id = 2,
            Nombre = "Eventia Planner",
            Descripcion = "Planeación y coordinación integral de eventos sociales y corporativos. Nos encargamos de cada detalle para que tu evento sea perfecto.",
            Stand = "STAND P-12",

            ImagenBannerUrl = "/imagenes/categorias/PlaneacionEventos.jpg",
            ImagenUrl = "/imagenes/Proveedores/planeacion-eventos.jpg",

            PrecioMinimo = 20000,
            PrecioMaximo = 80000,

            Ciudad = "Monterrey",
            Estado = "Nuevo León",
            Direccion = "Av. Constitución 1234, Centro",

            Telefono = "8112345678",
            WhatsApp = "https://wa.me/528112345678",

            UrlSitioWeb = "https://eventiaplanner.com/",
            SitioWeb = "https://eventiaplanner.com/",

            FechaCreacion = DateTime.Now,
            Activo = true,

            // 🔹 CATEGORÍA CORRECTA
            CategoriaId = CategoriasData.PlaneacionEventos.Id,
            Categoria = CategoriasData.PlaneacionEventos,

            // 🔹 TAGS AJUSTADOS A PLANEACIÓN
            TagsProvedors = new List<TagsProvedor>
    {
        new() { TagId = TagsData.WeddingPlanner.Id, Tag = TagsData.WeddingPlanner },
        new() { TagId = TagsData.CoordinacionEvento.Id, Tag = TagsData.CoordinacionEvento },
        new() { TagId = TagsData.Logistica.Id, Tag = TagsData.Logistica },
        new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas },
        new() { TagId = TagsData.XVAnos.Id, Tag = TagsData.XVAnos }
    },

            Horarios = new List<Horarios>
    {
        new() { DiaSemana = "Lunes a Viernes", HoraApertura = new(9,0,0), HoraCierre = new(18,0,0) },
        new() { DiaSemana = "Sábado", HoraApertura = new(10,0,0), HoraCierre = new(14,0,0) }
    },

            Galeria = new List<ImagenProveedor>
    {
        new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" },
        new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" },
        new() { Url = "/imagenes/categorias/SalonesyLocaciones.jpg" }
    },

            RedesSociales = new RedesSociales
            {
                Facebook = "https://facebook.com/eventiaplanner",
                Instagram = "https://instagram.com/eventiaplanner",
                Twitter = "https://twitter.com/eventiaplan",
                YouTube = "https://youtube.com/eventiaplanner"
            },

            Productos = new List<Productos>
    {
        new()
        {
            Id = 1,
            Nombre = "Planeación Parcial",
            Descripcion = "Asesoría, coordinación de proveedores y logística del evento.",
            Precio = 20000,
            ImagenUrl = "/imagenes/categorias/planeacion1.jpg",
            Activo = true,
            Destacado = false
        },
        new()
        {
            Id = 2,
            Nombre = "Planeación Integral",
            Descripcion = "Planeación completa desde cero, coordinación total y supervisión el día del evento.",
            Precio = 80000,
            ImagenUrl = "/imagenes/categorias/planeacion2.jpg",
            Activo = true,
            Destacado = true
        }
    },

            Resenas = new List<Resena>
    {
        new() { Id = 1, Calificacion = 5, Nombre = "Andrea", Comentario = "Nos ayudaron en todo, cero estrés.", FechaCreacion = DateTime.Now.AddDays(-15) },
        new() { Id = 2, Calificacion = 5, Nombre = "Carlos", Comentario = "Excelente organización y atención.", FechaCreacion = DateTime.Now.AddDays(-7) }
    }
        };

        public static readonly Proveedor Invboxv = new()
        {
            Id = 1,
            Nombre = "Invboxv",
            Descripcion = "Invitaciones Digitales, aplicacion para eventos, confirmaciones electronicas y invitaciones fisica.",
            Stand = "STAND B-24",

            ImagenBannerUrl = "/imagenes/categorias/InvitacionesPapelería.jpg",
            ImagenUrl = "/imagenes/Proveedores/provedor.jpg",

            PrecioMinimo = 15000,
            PrecioMaximo = 45000,

            Ciudad = "Monclova",
            Estado = "Coahulia",
            Direccion = "Av. Primavera, Estaciones",

            Telefono = "8180001122",
            WhatsApp = "https://wa.me/528180001122",

            UrlSitioWeb = "http://invboxv.com/",
            SitioWeb = "http://invboxv.com/",

            FechaCreacion = DateTime.Now,
            Activo = true,

            CategoriaId = CategoriasData.InvitacionesPapeleria.Id,
            Categoria = CategoriasData.InvitacionesPapeleria,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.Invitaciones.Id, Tag = TagsData.Invitaciones },
                new() { TagId = TagsData.PapeleriaPersonalizada.Id, Tag = TagsData.PapeleriaPersonalizada },
                new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas }
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

            Resenas = new List<Resena>
            {
                new() { Id = 1, Calificacion = 5, Nombre="Jose", Comentario = "Excelente trabajo.", FechaCreacion = DateTime.Now.AddDays(-10) },
                new() { Id = 2, Calificacion = 4, Nombre="Maria", Comentario = "Muy profesionales.", FechaCreacion = DateTime.Now.AddDays(-6) }
            }
        };

        public static readonly Proveedor AndreiPerezWeddings = new()
        {
            Id = 1,
            Nombre = "Andrei Pérez Weddings",
            Descripcion = "Capturamos los momentos más importantes de tu evento con un estilo cinematográfico, elegante y emocional.",
            Stand = "STAND B-23",

            ImagenBannerUrl = "/imagenes/categorias/fotografia-categoria.jpg",
            ImagenUrl = "/imagenes/Proveedores/provedor.jpg",

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
                new() { TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas }
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

            Resenas = new List<Resena>
            {
                new() { Id = 1, Calificacion = 5, Nombre="Jose", Comentario = "Excelente trabajo.", FechaCreacion = DateTime.Now.AddDays(-10) },
                new() { Id = 2, Calificacion = 4,  Nombre="Jose", Comentario = "Muy profesionales.", FechaCreacion = DateTime.Now.AddDays(-6) }
            }
        };

        public static readonly Proveedor LuzEnfoqueStudio = new()
        {
            Id = 2,
            Nombre = "Luz & Enfoque Studio",
            Descripcion = "Fotografía artística y profesional para bodas y eventos sociales.",
            Stand = "STAND A-01",

            ImagenBannerUrl = "/imagenes/categorias/fotografia-categoria.jpg",
            ImagenUrl = "/imagenes/Proveedores/provedor.jpg",

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
                new() {TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas}
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

            Resenas = new List<Resena>
            {
                new() { Id = 1, Calificacion = 5,  Nombre="Jose", Comentario = "Excelente trabajo.", FechaCreacion = DateTime.Now.AddDays(-10) },
                new() { Id = 2, Calificacion = 4, Nombre="Jose", Comentario = "Muy profesionales.", FechaCreacion = DateTime.Now.AddDays(-6) }
            }
        };

        public static readonly Proveedor BeatWaveProductions = new()
        {
            Id = 3,
            Nombre = "BeatWave Productions",
            Descripcion = "DJ profesional y música en vivo para bodas, fiestas y eventos corporativos.",
            Stand = "STAND B-05",

            ImagenBannerUrl = "/imagenes/categorias/DJ.jpg",
            ImagenUrl = "/imagenes/Proveedores/provedor.jpg",

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

            CategoriaId = CategoriasData.MusicaAnimacion.Id,
            Categoria = CategoriasData.MusicaAnimacion,

            TagsProvedors = new List<TagsProvedor>
            {
                new() { TagId = TagsData.MusicaEnVivo.Id, Tag = TagsData.MusicaEnVivo },
                new() {TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas}
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

            Resenas = new List<Resena>
            {
                new() { Id = 3, Calificacion = 5, Nombre="Jose", Comentario = "Ambiente increíble toda la noche.", FechaCreacion = DateTime.Now.AddDays(-8) },
                new() { Id = 4, Calificacion = 4, Nombre="Jose", Comentario = "Excelente música y sonido.", FechaCreacion = DateTime.Now.AddDays(-4) }
            }
        };

        public static readonly Proveedor HaciendaLosEncinos = new()
        {
            Id = 4,
            Nombre = "Hacienda Los Encinos",
            Descripcion = "Hacienda exclusiva para bodas y eventos sociales rodeada de naturaleza.",
            Stand = "STAND C-02",

            ImagenBannerUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
            ImagenUrl = "/imagenes/Proveedores/provedor.jpg",

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

            CategoriaId = CategoriasData.SalonesEspacios.Id,
            Categoria = CategoriasData.SalonesEspacios,

            TagsProvedors = new List<TagsProvedor>
            {
                new() {TagId = TagsData.Bodas.Id, Tag = TagsData.Bodas},
                new() {TagId = TagsData.SalonEventos.Id, Tag = TagsData.SalonEventos },
                new() {TagId = TagsData.EventosSociales.Id, Tag = TagsData.EventosSociales }
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

            Resenas = new List<Resena>
            {
                new() { Id = 5, Calificacion = 5, Nombre="Jose", Comentario = "Lugar espectacular y excelente atención.", FechaCreacion = DateTime.Now.AddDays(-12) },
                new() { Id = 6, Calificacion = 5, Nombre="Jose", Comentario = "La mejor locación para bodas.", FechaCreacion = DateTime.Now.AddDays(-7) }
            }
        };
    }
}