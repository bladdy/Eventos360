using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Data
{
    public static class TagsData
    {
        public static readonly Tags Boda = new() { Id = 1, Nombre = "Bodas" };
        public static readonly Tags XVAnos = new() { Id = 2, Nombre = "XV Años" };
        public static readonly Tags Cumpleanos = new() { Id = 3, Nombre = "Cumpleaños" };
        public static readonly Tags Corporativos = new() { Id = 4, Nombre = "Eventos Corporativos" };
        public static readonly Tags Graduaciones = new() { Id = 5, Nombre = "Graduaciones" };
        public static readonly Tags BabyShower = new() { Id = 6, Nombre = "Baby Shower" };
        public static readonly Tags DespedidaSoltera = new() { Id = 7, Nombre = "Despedida de Soltera" };
        public static readonly Tags Aniversarios = new() { Id = 8, Nombre = "Aniversarios" };
        public static readonly Tags Tematicos = new() { Id = 9, Nombre = "Fiestas Temáticas" };
        public static readonly Tags Sociales = new() { Id = 10, Nombre = "Eventos Sociales" };
        public static readonly Tags Empresariales = new() { Id = 11, Nombre = "Eventos Empresariales" };
        public static readonly Tags AireLibre = new() { Id = 12, Nombre = "Eventos al Aire Libre" };
        public static readonly Tags Lujo = new() { Id = 13, Nombre = "Eventos de Lujo" };
        public static readonly Tags Intimos = new() { Id = 14, Nombre = "Eventos Íntimos" };
        public static readonly Tags Masivos = new() { Id = 15, Nombre = "Eventos Masivos" };
        public static readonly Tags Religiosos = new() { Id = 16, Nombre = "Eventos Religiosos" };
        public static readonly Tags Privados = new() { Id = 17, Nombre = "Eventos Privados" };
        public static readonly Tags Nocturnos = new() { Id = 18, Nombre = "Eventos Nocturnos" };
        public static readonly Tags Diurnos = new() { Id = 19, Nombre = "Eventos Diurnos" };
        public static readonly Tags Personalizados = new() { Id = 20, Nombre = "Eventos Personalizados" };
        public static readonly Tags Video = new() { Id = 21, Nombre = "Video" };
        public static readonly Tags Fotografia = new() { Id = 22, Nombre = "Fotografía" };
        public static readonly Tags Salon = new() { Id = 23, Nombre = "Salon" };
        public static readonly Tags Musica = new() { Id = 24, Nombre = "Musica" };
        public static readonly Tags MusicaEnvivo = new() { Id = 25, Nombre = "Musica En vivo" };

        public static readonly List<Tags> Todos = new()
        {
            Boda,
            XVAnos,
            Cumpleanos,
            Corporativos,
            Graduaciones,
            BabyShower,
            DespedidaSoltera,
            Aniversarios,
            Tematicos,
            Sociales,
            Empresariales,
            AireLibre,
            Lujo,
            Intimos,
            Masivos,
            Religiosos,
            Privados,
            Nocturnos,
            Diurnos,
            Personalizados,
            Video,
            Fotografia,
            Salon
        };
    }
}