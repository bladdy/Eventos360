using Eventos360.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Eventos360.Frontend.Components
{
    public partial class ProveedoresComponent : IAsyncDisposable
    {
        [Inject] private IJSRuntime JS { get; set; } = default!;

        [Parameter] public string CategoriaNombre { get; set; } = string.Empty;
        [Parameter] public string CategoriaDescripcion { get; set; } = string.Empty;
        [Parameter] public string CategoriaImagenUrl { get; set; } = string.Empty;
        [Parameter] public List<ProveedorDTO> Proveedores { get; set; } = new();

        public List<ProveedorDTO> VisiblesProveedores { get; set; } = new();
        private double touchStartX;
        private int StartIndex = 0;
        private int VisibleCount = 1;
        private const int MaxVisible = 6;

        private const int CardWidth = 260;
        private const int Gap = 20;

        private ElementReference CarouselProveeRef;
        private DotNetObjectReference<ProveedoresComponent>? ObjRef;

        private string TranslateX => "0px";

        protected override Task OnInitializedAsync()
        {
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
                await JS.InvokeVoidAsync("carouselInterop.observe", CarouselProveeRef, ObjRef);
                await JS.InvokeVoidAsync("carouselInterop.enableSwipe", CarouselProveeRef, ObjRef);
            }
        }

        [JSInvokable]
        public void OnResize(double width)
        {
            VisibleCount = Math.Max(1, (int)(width / (CardWidth + Gap)));
            StartIndex = 0;
            UpdateVisible();
            StateHasChanged();
        }

        private void Next()
        {
            if (Proveedores.Count <= 0) return;

            StartIndex = (StartIndex + 1) % Proveedores.Count;

            UpdateVisible();
        }

        private void Prev()
        {
            if (Proveedores.Count <= 0) return;

            StartIndex =
        (StartIndex - 1 + Proveedores.Count)
        % Proveedores.Count;

            UpdateVisible();
        }

        [JSInvokable] public void SwipeNext() => Next();

        [JSInvokable] public void SwipePrev() => Prev();

        private void UpdateVisible()
        {
            VisiblesProveedores.Clear();

            if (Proveedores.Count == 0) return;

            for (int i = 0; i < VisibleCount; i++)
            {
                int index = (StartIndex + i) % Proveedores.Count;
                VisiblesProveedores.Add(Proveedores[index]);
            }
        }

        public ValueTask DisposeAsync()
        {
            ObjRef?.Dispose();
            return ValueTask.CompletedTask;
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