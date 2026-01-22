using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Data
{
    public static class CategoriasData
    {
        public static readonly Categoria SalonesEspacios = new()
        {
            Id = 1,
            Nombre = "Salones y Espacios para Eventos",
            Descripcion = "Espacios ideales para todo tipo de celebraciones y eventos.",
            ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria PlaneacionEventos = new()
        {
            Id = 2,
            Nombre = "Planeación y Coordinación de Eventos",
            Descripcion = "Expertos en organizar, coordinar y producir eventos exitosos.",
            ImagenUrl = "/imagenes/categorias/OrganizacionyWeddingPlanner.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria BanquetesCatering = new()
        {
            Id = 3,
            Nombre = "Banquetes y Catering",
            Descripcion = "Servicios gastronómicos para eventos sociales y corporativos.",
            ImagenUrl = "/imagenes/categorias/Banquetes.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria BebidasBarras = new()
        {
            Id = 4,
            Nombre = "Bebidas y Barras",
            Descripcion = "Barras móviles, mixología y bebidas para todo tipo de eventos.",
            ImagenUrl = "/imagenes/categorias/Banquetes.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria DecoracionAmbientacion = new()
        {
            Id = 5,
            Nombre = "Decoración y Ambientación",
            Descripcion = "Diseño, ambientación y decoración personalizada para eventos.",
            ImagenUrl = "/imagenes/categorias/DecoraciónyAmbientacion.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria Floreria = new()
        {
            Id = 6,
            Nombre = "Florería",
            Descripcion = "Diseño floral profesional para eventos y celebraciones.",
            ImagenUrl = "/imagenes/categorias/Banquetes.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria MusicaAnimacion = new()
        {
            Id = 7,
            Nombre = "Música y Animación",
            Descripcion = "Entretenimiento musical y animación para eventos.",
            ImagenUrl = "/imagenes/categorias/DJ.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria ShowsEspectaculos = new()
        {
            Id = 8,
            Nombre = "Shows y Espectáculos",
            Descripcion = "Espectáculos visuales y artísticos para sorprender.",
            ImagenUrl = "/imagenes/categorias/IluminaciónyAudio.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria FotografiaVideo = new()
        {
            Id = 9,
            Nombre = "Fotografía y Video",
            Descripcion = "Captura profesional de los mejores momentos del evento.",
            ImagenUrl = "/imagenes/categorias/fotografia.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria CabinasExperiencias = new()
        {
            Id = 10,
            Nombre = "Cabinas y Experiencias Interactivas",
            Descripcion = "Experiencias tecnológicas y entretenimiento interactivo.",
            ImagenUrl = "/imagenes/categorias/fotografia.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria InvitacionesPapeleria = new()
        {
            Id = 11,
            Nombre = "Invitaciones y Papelería",
            Descripcion = "Diseño de invitaciones y papelería personalizada.",
            ImagenUrl = "/imagenes/categorias/InvitacionesyPapeleria.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria VestuarioModa = new()
        {
            Id = 12,
            Nombre = "Vestuario y Moda",
            Descripcion = "Vestimenta y moda para eventos sociales.",
            ImagenUrl = "/imagenes/categorias/MaquillajeyPeinado.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria MaquillajePeinado = new()
        {
            Id = 13,
            Nombre = "Maquillaje y Peinado",
            Descripcion = "Servicios profesionales de maquillaje y peinado.",
            ImagenUrl = "/imagenes/categorias/MaquillajeyPeinado.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria AccesoriosJoyeria = new()
        {
            Id = 14,
            Nombre = "Accesorios y Joyería",
            Descripcion = "Accesorios y joyería para eventos especiales.",
            ImagenUrl = "/imagenes/categorias/MaquillajeyPeinado.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria ProtocoloCeremonia = new()
        {
            Id = 15,
            Nombre = "Protocolo y Ceremonia",
            Descripcion = "Servicios para ceremonias civiles, religiosas y simbólicas.",
            ImagenUrl = "/imagenes/categorias/OrganizacionyWeddingPlanner.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria MobiliarioMontaje = new()
        {
            Id = 16,
            Nombre = "Mobiliario y Montaje",
            Descripcion = "Renta y montaje de mobiliario para eventos.",
            ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria AudioIluminacion = new()
        {
            Id = 17,
            Nombre = "Audio, Iluminación y Producción",
            Descripcion = "Producción técnica integral para eventos.",
            ImagenUrl = "/imagenes/categorias/IluminacionyAudio.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria TransporteEventos = new()
        {
            Id = 18,
            Nombre = "Transporte para Eventos",
            Descripcion = "Traslados y transporte especializado para eventos.",
            ImagenUrl = "/imagenes/categorias/TransporteyTraslados.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria DetallesRecuerdos = new()
        {
            Id = 19,
            Nombre = "Detalles y Recuerdos",
            Descripcion = "Recuerdos personalizados y detalles para invitados.",
            ImagenUrl = "/imagenes/categorias/PastelesyRepostería.jpg",
            Proveedores = new List<Proveedor>()
        };

        // LISTADO GENERAL
        public static readonly List<Categoria> Todas =
        [
            SalonesEspacios,
            PlaneacionEventos,
            BanquetesCatering,
            BebidasBarras,
            DecoracionAmbientacion,
            Floreria,
            MusicaAnimacion,
            ShowsEspectaculos,
            FotografiaVideo,
            CabinasExperiencias,
            InvitacionesPapeleria,
            VestuarioModa,
            MaquillajePeinado,
            AccesoriosJoyeria,
            ProtocoloCeremonia,
            MobiliarioMontaje,
            AudioIluminacion,
            TransporteEventos,
            DetallesRecuerdos
        ];
    }
}