using Eventos360.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Eventos360.Frontend.Components
{
    public partial class ProveedoresComponent
    {
        [Parameter] public string CategoriaNombre { get; set; } = string.Empty;
        [Parameter] public string CategoriaDescripcion { get; set; } = string.Empty;
        [Parameter] public string CategoriaImagenUrl { get; set; } = string.Empty;

        [Parameter] public List<ProveedorDTO> Proveedores { get; set; } = new();

        private List<ProveedorDTO> VisibleProveedores = new();

        private int StartIndex = 0;
        private int VisibleCount = 1;

        private const int CardWidth = 260;
        private const int Gap = 20;

        private double touchStartX;

        protected override void OnInitialized()
        {
            VisibleCount = 1;
            UpdateVisible();
        }

        private void UpdateVisible()
        {
            VisibleProveedores.Clear();

            if (Proveedores.Count == 0) return;

            for (int i = 0; i < VisibleCount; i++)
            {
                int index = (StartIndex + i) % Proveedores.Count;
                VisibleProveedores.Add(Proveedores[index]);
            }
        }

        private void Next()
        {
            if (Proveedores.Count == 0) return;

            StartIndex = (StartIndex + 1) % Proveedores.Count;
            UpdateVisible();
        }

        private void Prev()
        {
            if (Proveedores.Count == 0) return;

            StartIndex = (StartIndex - 1 + Proveedores.Count) % Proveedores.Count;
            UpdateVisible();
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