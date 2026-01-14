using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Data
{
    public static class CategoriasData
    {
        public static readonly Categoria FotografiaVideo = new()
        {
            Id = 1,
            Nombre = "Fotografía y Video",
            Descripcion = "Fotógrafos y videógrafos profesionales para capturar los mejores momentos de tu evento.",
            ImagenUrl = "/imagenes/categorias/fotografia.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria DjMusica = new()
        {
            Id = 2,
            Nombre = "DJ y Música en Vivo",
            Descripcion = "DJ, bandas y grupos musicales para animar cualquier tipo de celebración.",
            ImagenUrl = "/imagenes/categorias/DJ.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria CateringBuffet = new()
        {
            Id = 3,
            Nombre = "Catering y Buffet",
            Descripcion = "Servicios de alimentos y bebidas para eventos sociales y corporativos.",
            ImagenUrl = "/imagenes/categorias/cateringybuffet.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria SalonesLocaciones = new()
        {
            Id = 4,
            Nombre = "Salones y Locaciones",
            Descripcion = "Salones, jardines y espacios ideales para todo tipo de eventos.",
            ImagenUrl = "/imagenes/categorias/SalonesyLocaciones.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria DecoracionAmbientacion = new()
        {
            Id = 5,
            Nombre = "Decoración y Ambientación",
            Descripcion = "Decoración temática, floral y ambientación personalizada para tu evento.",
            ImagenUrl = "/imagenes/categorias/DecoraciónyAmbientación.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria IluminacionAudio = new()
        {
            Id = 6,
            Nombre = "Iluminación y Audio",
            Descripcion = "Iluminación profesional y sistemas de audio para eventos de cualquier tamaño.",
            ImagenUrl = "/imagenes/categorias/IluminaciónyAudio.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria Banquetes = new()
        {
            Id = 7,
            Nombre = "Banquetes",
            Descripcion = "Banquetes completos con menús personalizados y servicio profesional.",
            ImagenUrl = "/imagenes/categorias/Banquetes.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria PastelesReposteria = new()
        {
            Id = 8,
            Nombre = "Pasteles y Repostería",
            Descripcion = "Pasteles, mesas de postres y repostería personalizada para eventos.",
            ImagenUrl = "/imagenes/categorias/PastelesyRepostería.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria RentaMobiliario = new()
        {
            Id = 9,
            Nombre = "Renta de Mobiliario",
            Descripcion = "Renta de mesas, sillas, carpas y mobiliario para eventos.",
            ImagenUrl = "/imagenes/categorias/RentaMobiliario.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria WeddingPlanner = new()
        {
            Id = 10,
            Nombre = "Organización y Wedding Planner",
            Descripcion = "Organizadores profesionales y wedding planners para eventos sin estrés.",
            ImagenUrl = "/imagenes/categorias/OrganizaciónyWeddingPlanner.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria AnimacionShows = new()
        {
            Id = 11,
            Nombre = "Animación y Shows",
            Descripcion = "Shows, animadores y entretenimiento para todo tipo de eventos.",
            ImagenUrl = "/imagenes/categorias/AnimaciónShows.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria MaquillajePeinado = new()
        {
            Id = 12,
            Nombre = "Maquillaje y Peinado",
            Descripcion = "Maquillistas y estilistas profesionales para eventos sociales.",
            ImagenUrl = "/imagenes/categorias/MaquillajeyPeinado.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria InvitacionesPapeleria = new()
        {
            Id = 13,
            Nombre = "Invitaciones y Papelería",
            Descripcion = "Invitaciones digitales, impresas y papelería personalizada.",
            ImagenUrl = "/imagenes/categorias/InvitacionesPapelería.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria TransporteTraslados = new()
        {
            Id = 14,
            Nombre = "Transporte y Traslados",
            Descripcion = "Transporte para invitados, novios o artistas.",
            ImagenUrl = "/imagenes/categorias/TransporteyTraslados.jpg",
            Proveedores = new List<Proveedor>()
        };

        public static readonly Categoria SeguridadLogistica = new()
        {
            Id = 15,
            Nombre = "Seguridad y Logística",
            Descripcion = "Personal de seguridad y logística para eventos grandes y pequeños.",
            ImagenUrl = "/imagenes/categorias/SeguridadyLogística.jpg",
            Proveedores = new List<Proveedor>()
        };

        // LISTADO GENERAL
        public static readonly List<Categoria> Todas =
        [
            FotografiaVideo,
            DjMusica,
            CateringBuffet,
            SalonesLocaciones,
            DecoracionAmbientacion,
            IluminacionAudio,
            Banquetes,
            PastelesReposteria,
            RentaMobiliario,
            WeddingPlanner,
            AnimacionShows,
            MaquillajePeinado,
            InvitacionesPapeleria,
            TransporteTraslados,
            SeguridadLogistica
        ];
    }
}