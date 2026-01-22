using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Data
{
    public static class TagsData
    {
        public static readonly Tags Bodas = new() { Id = 1, Nombre = "Bodas" };
        public static readonly Tags XVAnos = new() { Id = 2, Nombre = "XV Años" };
        public static readonly Tags EventosSociales = new() { Id = 3, Nombre = "Eventos sociales" };
        public static readonly Tags EventosCorporativos = new() { Id = 4, Nombre = "Eventos corporativos" };

        public static readonly Tags SalonEventos = new() { Id = 5, Nombre = "Salón de eventos" };
        public static readonly Tags Jardin = new() { Id = 6, Nombre = "Jardín" };
        public static readonly Tags Hacienda = new() { Id = 7, Nombre = "Hacienda" };
        public static readonly Tags Terraza = new() { Id = 8, Nombre = "Terraza" };
        public static readonly Tags Rooftop = new() { Id = 9, Nombre = "Rooftop" };

        public static readonly Tags WeddingPlanner = new() { Id = 10, Nombre = "Wedding planner" };
        public static readonly Tags CoordinacionEvento = new() { Id = 11, Nombre = "Coordinación de eventos" };
        public static readonly Tags Logistica = new() { Id = 12, Nombre = "Logística" };

        public static readonly Tags Banquete = new() { Id = 13, Nombre = "Banquete" };
        public static readonly Tags Catering = new() { Id = 14, Nombre = "Catering" };
        public static readonly Tags Buffet = new() { Id = 15, Nombre = "Buffet" };
        public static readonly Tags Taquiza = new() { Id = 16, Nombre = "Taquiza" };

        public static readonly Tags BarraLibre = new() { Id = 17, Nombre = "Barra libre" };
        public static readonly Tags Mixologia = new() { Id = 18, Nombre = "Mixología" };
        public static readonly Tags CafeBar = new() { Id = 19, Nombre = "Café bar" };

        public static readonly Tags Decoracion = new() { Id = 20, Nombre = "Decoración" };
        public static readonly Tags CentrosMesa = new() { Id = 21, Nombre = "Centros de mesa" };
        public static readonly Tags Backdrops = new() { Id = 22, Nombre = "Backdrops" };

        public static readonly Tags FloreriaEventos = new() { Id = 23, Nombre = "Florería para eventos" };
        public static readonly Tags RamosNovia = new() { Id = 24, Nombre = "Ramos de novia" };

        public static readonly Tags DJ = new() { Id = 25, Nombre = "DJ" };
        public static readonly Tags Mariachi = new() { Id = 26, Nombre = "Mariachi" };
        public static readonly Tags MusicaEnVivo = new() { Id = 27, Nombre = "Música en vivo" };

        public static readonly Tags Fotografia = new() { Id = 28, Nombre = "Fotografía" };
        public static readonly Tags Video = new() { Id = 29, Nombre = "Video" };
        public static readonly Tags Drone = new() { Id = 30, Nombre = "Drone" };

        public static readonly Tags Cabina360 = new() { Id = 31, Nombre = "Cabina 360" };
        public static readonly Tags EspejoMagico = new() { Id = 32, Nombre = "Espejo mágico" };

        public static readonly Tags Invitaciones = new() { Id = 33, Nombre = "Invitaciones" };
        public static readonly Tags PapeleriaPersonalizada = new() { Id = 34, Nombre = "Papelería personalizada" };

        public static readonly Tags VestidosNovia = new() { Id = 35, Nombre = "Vestidos de novia" };
        public static readonly Tags Tuxedos = new() { Id = 36, Nombre = "Tuxedos" };

        public static readonly Tags Maquillaje = new() { Id = 37, Nombre = "Maquillaje" };
        public static readonly Tags Peinado = new() { Id = 38, Nombre = "Peinado" };

        public static readonly Tags Anillos = new() { Id = 39, Nombre = "Anillos" };
        public static readonly Tags Joyeria = new() { Id = 40, Nombre = "Joyería" };

        public static readonly Tags Ceremonia = new() { Id = 41, Nombre = "Ceremonia" };
        public static readonly Tags MaestroCeremonias = new() { Id = 42, Nombre = "Maestro de ceremonias" };

        public static readonly Tags Mobiliario = new() { Id = 43, Nombre = "Mobiliario" };
        public static readonly Tags PistaBaile = new() { Id = 44, Nombre = "Pista de baile" };

        public static readonly Tags Iluminacion = new() { Id = 45, Nombre = "Iluminación" };
        public static readonly Tags Audio = new() { Id = 46, Nombre = "Audio profesional" };

        public static readonly Tags Transporte = new() { Id = 47, Nombre = "Transporte para eventos" };
        public static readonly Tags AutosLujo = new() { Id = 48, Nombre = "Autos de lujo" };

        public static readonly Tags Recuerdos = new() { Id = 49, Nombre = "Recuerdos personalizados" };
        public static readonly Tags Souvenirs = new() { Id = 50, Nombre = "Souvenirs" };
        public static readonly Tags ServicioMeseros = new() { Id = 51, Nombre = "Servicio Meseros" };
        public static readonly Tags BanqueteFormal = new() { Id = 52, Nombre = "Banquete Formal" };
        public static readonly Tags CateringBodas = new() { Id = 53, Nombre = "Catering para Bodas" };
        public static readonly Tags Coordinacion = new() { Id = 54, Nombre = "Coordinacion" };

        public static readonly List<Tags> Todos =
        [
            Bodas,
            XVAnos,
            EventosSociales,
            EventosCorporativos,

            SalonEventos,
            Jardin,
            Hacienda,
            Terraza,
            Rooftop,

            WeddingPlanner,
            CoordinacionEvento,
            Logistica,

            Banquete,
            Catering,
            Buffet,
            Taquiza,

            BarraLibre,
            Mixologia,
            CafeBar,

            Decoracion,
            CentrosMesa,
            Backdrops,

            FloreriaEventos,
            RamosNovia,

            DJ,
            Mariachi,
            MusicaEnVivo,

            Fotografia,
            Video,
            Drone,

            Cabina360,
            EspejoMagico,

            Invitaciones,
            PapeleriaPersonalizada,

            VestidosNovia,
            Tuxedos,

            Maquillaje,
            Peinado,

            Anillos,
            Joyeria,

            Ceremonia,
            MaestroCeremonias,

            Mobiliario,
            PistaBaile,

            Iluminacion,
            Audio,

            Transporte,
            AutosLujo,

            Recuerdos,
            Souvenirs
        ];
    }
}

/*
 ✅ CATEGORÍAS FINALES DEL DIRECTORIO (19)
1. Salones y Espacios para Eventos

Salones de eventos

Jardines

Haciendas

Quintas

Terrazas

Rooftops

Salones boutique

Salones infantiles (XV)

Espacios rústicos

Centros de eventos

2. Planeación y Coordinación de Eventos

Wedding planner

Planeación de XV años

Coordinación integral

Coordinación del día

Organización parcial

Producción del evento

Asesoría previa

Planeación personalizada

Coordinación de proveedores

Logística y cronograma

3. Banquetes y Catering

Banquete formal

Catering para bodas

Catering para XV

Buffet

Taquizas

Parrilladas

Comida tradicional mexicana

Menús personalizados

Servicio de meseros

Tornabodas

4. Bebidas y Barras

Barra libre

Mixología

Barra de shots

Coctelería

Barra sin alcohol

Café bar

Bebidas especiales

Cervezas artesanales

Vinos y licores

Barra móvil

5. Decoración y Ambientación

Decoración integral

Decoración temática

Decoración boho

Decoración rústica

Centros de mesa

Backdrops

Letras gigantes

Decoración personalizada

Ambientación completa

Styling del evento

6. Florería

Ramos de novia

Ramos de XV

Arreglos florales

Decoración floral

Arcos florales

Centros de mesa florales

Flores naturales

Flores artificiales

Diseño floral personalizado

Florería para eventos

7. Música y Animación

DJ para bodas

DJ para XV

Grupos versátiles

Mariachi

Banda

Música en vivo

Animadores

Saxofonista / Violinista

Batucada

Ambientación musical

8. Shows y Espectáculos

Show LED

Show sorpresa

Show de fuego

Performances

Bailarines

Flashmob

Entrada especial

Coreografías especiales

Shows temáticos

Experiencias escénicas

9. Fotografía y Video

Fotografía profesional

Fotografía artística

Video profesional

Video cinematográfico

Drone

Highlights

Same day edit

Álbum digital

Álbum impreso

Sesiones pre evento

10. Cabinas y Experiencias Interactivas

Cabina de fotos

Cabina 360

Plataforma 360

Espejo mágico

Robot LED

Experiencias interactivas

Activaciones digitales

Cabinas premium

Experiencias personalizadas

Entretenimiento interactivo

11. Invitaciones y Papelería

Invitaciones digitales

Invitaciones impresas

Save the date

Menús

Seating plan

Números de mesa

Señalética

Sobres personalizados

Tarjetas de agradecimiento

Papelería personalizada

12. Vestuario y Moda

Vestidos de novia

Vestidos de XV

Cambios de vestido

Trajes y tuxedos

Vestuario de damas

Vestuario de chambelanes

Pajes

Renta de vestuario

Venta de vestuario

Ajustes y modificaciones

13. Maquillaje y Peinado

Maquillaje de novia

Maquillaje de XV

Maquillaje social

Maquillaje HD

Peinado profesional

Pruebas de maquillaje

Paquetes completos

Servicio a domicilio

Maquillaje artístico

Styling integral

14. Accesorios y Joyería

Anillos de compromiso

Argollas matrimoniales

Coronas y tiaras

Aretes

Collares

Accesorios para XV

Accesorios personalizados

Joyería fina

Joyería de fantasía

Grabados

15. Protocolo y Ceremonia

Iglesias

Oficiales civiles

Ministros o pastores

Maestro de ceremonias

Ceremonias simbólicas

Música para ceremonia

Coros

Lectores

Decoración de ceremonia

Asesoría ceremonial

16. Mobiliario y Montaje

Mesas

Sillas

Sillas premium

Mantelería

Vajilla

Cristalería

Carpas

Pistas de baile

Estructuras

Mobiliario lounge

17. Audio, Iluminación y Producción

Audio profesional

Iluminación ambiental

Iluminación arquitectónica

Pantallas LED

Escenarios

Truss

DJ booth

Operadores técnicos

Producción integral

Efectos especiales

18. Transporte para Eventos

Autos clásicos

Autos de lujo

Limusinas

Party bus

Transporte para invitados

Vans

Autobuses

Vehículos decorados

Traslados especiales

Servicio con chofer

19. Detalles y Recuerdos

Recuerdos personalizados

Souvenirs

Kits de bienvenida

Mesa de firmas

Libros de deseos

Velas

Regalos para padrinos

Fotorecuerdos

Detalles premium

Detalles ecológicos
 */