using Eventos360.Shared.DTOs;

namespace Eventos360.Frontend.Components
{
    public partial class ProveedoresTagsComponent
    {
        private List<TagsDTO> Tags = new List<TagsDTO>
        {
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Bodas" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "XV Años" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Cumpleaños" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Corporativos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Graduaciones" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Baby Shower" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Despedida de Soltera" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Aniversarios" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Fiestas Temáticas" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Sociales" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Empresariales" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos al Aire Libre" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos de Lujo" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Íntimos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Masivos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Religiosos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Privados" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Nocturnos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Diurnos" },
            new TagsDTO { Id = Guid.NewGuid(), Nombre = "Eventos Personalizados" }
        };
    }
}