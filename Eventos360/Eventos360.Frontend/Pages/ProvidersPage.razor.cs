using Eventos360.Frontend.Data;
using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Eventos360.Frontend.Pages
{
    public partial class ProvidersPage
    {
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;
        [Parameter] public string? Stand { get; set; }
        private Proveedor? selectedProveedor;
        private List<Proveedor> proveedores = [];

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Stand))
            {
                NavigationManager.NavigateTo("/search");
            }
            proveedores = ProveedoresData.Todos;
            selectedProveedor = proveedores.Where(p => p.Stand == Stand).FirstOrDefault();
        }

        private double PromedioCalificacion =>
            selectedProveedor?.Resenas.Any() == true
                ? Math.Round(selectedProveedor.Resenas.Average(r => r.Calificacion), 1)
                : 0;
    }
}