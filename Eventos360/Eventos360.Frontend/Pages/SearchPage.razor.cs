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
        public int? categoriaId { get; set; }

        [Parameter, SupplyParameterFromQuery]
        public string? categoria { get; set; }

        // ?tags=foto&tags=video
        [Parameter, SupplyParameterFromQuery]
        public string[]? tags { get; set; }

        // 🔹 Datos base (NO se modifican)
        private List<Proveedor> AllProveedors = [];

        private List<Categoria> Categorias = [];
        private List<Tags> Tags = [];

        // 🔹 Resultado filtrado
        private List<Proveedor> Proveedors = [];

        // 🔹 Filtros internos
        private List<string> SelectedTags = [];

        [Inject] private NavigationManager Navigation { get; set; } = default!;

        protected override void OnInitialized()
        {
            AllProveedors = ProveedoresData.Todos;
            Categorias = CategoriasData.Todas;
            Tags = TagsData.Todos;

            if (tags is { Length: > 0 })
                SelectedTags = tags.Distinct().ToList();

            AplicarFiltros();
        }

        // 🔹 MÉTODO REUTILIZABLE DE FILTROS
        private void AplicarFiltros()
        {
            IEnumerable<Proveedor> query = AllProveedors;

            // 🔸 Filtrar por categoría
            if (categoriaId.HasValue)
            {
                query = query.Where(p =>
                    p.CategoriaId == categoriaId.Value);
            }

            // 🔸 Filtrar por tags
            if (SelectedTags.Any())
            {
                query = query.Where(p =>
                    p.TagsProvedors.Any(tp =>
                        SelectedTags.Contains(tp.Tag.Nombre)));
            }

            Proveedors = query.ToList();
        }

        // 🔹 Agregar tag
        private void ToggleFiltroTag(string tag)
        {
            if (SelectedTags.Contains(tag))
                SelectedTags.Remove(tag);
            else
                SelectedTags.Add(tag);

            UpdateUrl();
        }

        // 🔹 Quitar tag
        private void RemoveFiltroTag(string tag)
        {
            if (!SelectedTags.Contains(tag))
                return;

            SelectedTags.Remove(tag);
            UpdateUrl();
        }

        // 🔹 Actualiza la URL y reaplica filtros
        private void UpdateUrl()
        {
            var query = new Dictionary<string, StringValues>();

            if (categoriaId.HasValue)
                query["categoriaId"] = categoriaId.Value.ToString();

            if (!string.IsNullOrWhiteSpace(categoria))
                query["categoria"] = categoria;

            if (SelectedTags.Any())
                query["tags"] = new StringValues(SelectedTags.ToArray());

            var uri = QueryHelpers.AddQueryString("/search", query);
            Navigation.NavigateTo(uri, forceLoad: false);

            AplicarFiltros();
        }
    }
}