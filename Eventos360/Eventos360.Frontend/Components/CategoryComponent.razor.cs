using Eventos360.Frontend.Data;
using Eventos360.Shared.DTOs;
using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Eventos360.Frontend.Components
{
    public partial class CategoryComponent
    {
        [Inject] private IJSRuntime JS { get; set; } = default!;
        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

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

        private List<Categoria> VisibleCategories = new();

        private List<Categoria> Categories = [];

        protected override Task OnInitializedAsync()
        {
            // Valor inicial seguro antes de JS
            Categories = CategoriasData.Todas;
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

        private void IrABusqueda(Categoria categoria)
        {
            var url = $"/search?categoriaId={categoria.Id}&categoria={Uri.EscapeDataString(categoria.Nombre)}";
            NavigationManager.NavigateTo(url);
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