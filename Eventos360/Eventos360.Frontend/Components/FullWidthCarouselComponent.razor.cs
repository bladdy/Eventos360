using Microsoft.AspNetCore.Components;

namespace Eventos360.Frontend.Components
{
    public partial class FullWidthCarouselComponent
    {
        [Parameter] public int Interval { get; set; } = 5000; // 5 segundos

        public List<string> Images { get; set; } = new List<string>
        {
            "/imagenes/categorias/Banquetes.jpg",
            "/imagenes/categorias/AnimaciónShows.jpg",
            "/imagenes/categorias/cateringybuffet.jpg"
        };
    }
}