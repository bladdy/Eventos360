using Eventos360.Frontend.Data;
using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace Eventos360.Frontend.Pages
{
    public partial class SearchPage
    {
        // 🔹 Parámetros desde la URL
        [Parameter, SupplyParameterFromQuery]
        public string? categoria { get; set; }

        [Parameter, SupplyParameterFromQuery]
        public string[]? tags { get; set; }

        // 🔹 Datos base
        private List<Proveedor> AllProveedors = [];

        private List<Proveedor> Proveedors = [];
        private List<Categoria> Categorias = [];
        private List<Tags> Tags = [];

        // 🔹 Estado interno
        private string? SelectedCategoria;

        private List<string> SelectedTags = [];

        [Inject] private NavigationManager Navigation { get; set; } = default!;

        protected override void OnInitialized()
        {
            AllProveedors = ProveedoresData.Todos;
            Categorias = CategoriasData.Todas;
            Tags = TagsData.Todos;
        }

        protected override void OnParametersSet()
        {
            // Sincronizar estado interno con URL
            SelectedCategoria = categoria;

            SelectedTags = tags is { Length: > 0 }
                ? tags.Distinct().ToList()
                : [];

            AplicarFiltros();
        }

        // 🔹 FILTRO CENTRAL
        private void AplicarFiltros()
        {
            IEnumerable<Proveedor> query = AllProveedors;

            if (!string.IsNullOrWhiteSpace(SelectedCategoria))
            {
                query = query.Where(p =>
                    p.Categoria.Nombre == SelectedCategoria);
            }

            if (SelectedTags.Any())
            {
                query = query.Where(p =>
                    p.TagsProvedors.Any(tp =>
                        SelectedTags.Contains(tp.Tag.Nombre)));
            }

            Proveedors = query.ToList();
        }

        // 🔹 Cambio de categoría
        private void OnCategoriaChange(ChangeEventArgs e)
        {
            SelectedCategoria = e.Value?.ToString();
            UpdateUrl();
        }

        // 🔹 Toggle tags
        private void ToggleFiltroTag(string tag)
        {
            if (SelectedTags.Contains(tag))
                SelectedTags.Remove(tag);
            else
                SelectedTags.Add(tag);

            UpdateUrl();
        }

        // 🔹 Actualiza la URL SIN destruir el componente
        private void UpdateUrl()
        {
            var query = new Dictionary<string, StringValues>();

            if (!string.IsNullOrWhiteSpace(SelectedCategoria))
                query["categoria"] = SelectedCategoria;

            if (SelectedTags.Any())
                query["tags"] = new StringValues(SelectedTags.ToArray());

            var uri = QueryHelpers.AddQueryString("/search", query);

            // ✅ replace evita recrear el componente (NO rompe JSInterop)
            Navigation.NavigateTo(uri, replace: true);
        }
    }
}