using Eventos360.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Eventos360.Frontend.Components
{
    public partial class CategoryComponent
    {
        [Inject] private IJSRuntime JS { get; set; } = default!;

        // Ajusta este valor según el diseño (260 + gap)
        private const int MaxVisible = 6;

        private double touchStartX;
        private ElementReference CarouselRef;

        private DotNetObjectReference<CategoryComponent>? ObjRef;

        private int StartIndex = 0;
        private int VisibleCount = 1;

        private const int CardWidth = 260;
        private const int Gap = 20;

        private string TranslateX => "0px";

        private List<CategoriaDTO> VisibleCategories = new();

        private List<CategoriaDTO> Categories = new List<CategoriaDTO>
        {
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Fotografía y Video",
                Descripcion = "Fotógrafos y videógrafos profesionales para capturar los mejores momentos de tu evento.",
                ImagenUrl = "/imagenes/categorias/fotografia.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "DJ y Música en Vivo",
                Descripcion = "DJ, bandas y grupos musicales para animar cualquier tipo de celebración.",
                ImagenUrl = "/images/categorias/dj-musica.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Catering y Buffet",
                Descripcion = "Servicios de alimentos y bebidas para eventos sociales y corporativos.",
                ImagenUrl = "/images/categorias/catering-buffet.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Salones y Locaciones",
                Descripcion = "Salones, jardines y espacios ideales para todo tipo de eventos.",
                ImagenUrl = "/images/categorias/salones-locaciones.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Decoración y Ambientación",
                Descripcion = "Decoración temática, floral y ambientación personalizada para tu evento.",
                ImagenUrl = "/images/categorias/decoracion.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Iluminación y Audio",
                Descripcion = "Iluminación profesional y sistemas de audio para eventos de cualquier tamaño.",
                ImagenUrl = "/images/categorias/iluminacion-audio.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Banquetes",
                Descripcion = "Banquetes completos con menús personalizados y servicio profesional.",
                ImagenUrl = "/images/categorias/banquetes.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Pasteles y Repostería",
                Descripcion = "Pasteles, mesas de postres y repostería personalizada para eventos.",
                ImagenUrl = "/images/categorias/pasteles.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Renta de Mobiliario",
                Descripcion = "Renta de mesas, sillas, carpas y mobiliario para eventos.",
                ImagenUrl = "/images/categorias/mobiliario.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Organización y Wedding Planner",
                Descripcion = "Organizadores profesionales y wedding planners para eventos sin estrés.",
                ImagenUrl = "/images/categorias/wedding-planner.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Animación y Shows",
                Descripcion = "Shows, animadores, payasos y entretenimiento para todo tipo de eventos.",
                ImagenUrl = "/images/categorias/animacion-shows.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Maquillaje y Peinado",
                Descripcion = "Maquillistas y estilistas profesionales para eventos sociales.",
                ImagenUrl = "/images/categorias/maquillaje-peinado.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Invitaciones y Papelería",
                Descripcion = "Invitaciones digitales, impresas y papelería personalizada.",
                ImagenUrl = "/images/categorias/invitaciones.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Transporte y Traslados",
                Descripcion = "Transporte para invitados, novios o artistas.",
                ImagenUrl = "/images/categorias/transporte.jpg",
                CantidadProveedores = 0
            },
            new CategoriaDTO
            {
                Id = Guid.NewGuid(),
                Nombre = "Seguridad y Logística",
                Descripcion = "Personal de seguridad y logística para eventos grandes y pequeños.",
                ImagenUrl = "/images/categorias/seguridad-logistica.jpg",
                CantidadProveedores = 0
            }
        };

        protected override Task OnInitializedAsync()
        {
            // Valor inicial seguro antes de JS
            VisibleCount = 1;
            StartIndex = 0;
            UpdateVisible();

            return Task.CompletedTask;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                ObjRef = DotNetObjectReference.Create(this);
                await JS.InvokeVoidAsync("carouselInterop.observe", CarouselRef, ObjRef);
                await JS.InvokeVoidAsync("carouselInterop.enableSwipe", CarouselRef, ObjRef);
            }
        }

        [JSInvokable]
        public void OnResize(double width)
        {
            VisibleCount = Math.Max(1, (int)(width / (CardWidth + Gap)));
            UpdateVisible();
            StateHasChanged();
        }

        private void UpdateVisible()
        {
            VisibleCategories.Clear();

            if (Categories.Count == 0) return;

            for (int i = 0; i < VisibleCount; i++)
            {
                int index = (StartIndex + i) % Categories.Count;
                VisibleCategories.Add(Categories[index]);
            }
        }

        private void Next()
        {
            if (Categories.Count == 0) return;
            StartIndex = (StartIndex + 1) % Categories.Count;
            UpdateVisible();
        }

        private void Prev()
        {
            if (Categories.Count == 0) return;
            StartIndex = (StartIndex - 1 + Categories.Count) % Categories.Count;
            UpdateVisible();
        }

        [JSInvokable]
        public void SwipeNext() => Next();

        [JSInvokable]
        public void SwipePrev() => Prev();

        public void Dispose()
        {
            ObjRef?.Dispose();
        }

        private void OnTouchStart(TouchEventArgs e)
        {
            touchStartX = e.Touches[0].ClientX;
        }

        private void OnTouchEnd(TouchEventArgs e)
        {
            var touchEndX = e.ChangedTouches[0].ClientX;
            var delta = touchStartX - touchEndX;

            if (delta > 50)
                Next();
            else if (delta < -50)
                Prev();
        }
    }
}