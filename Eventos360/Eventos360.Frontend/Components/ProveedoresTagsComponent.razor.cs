using Eventos360.Frontend.Data;
using Eventos360.Shared.DTOs;
using Eventos360.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace Eventos360.Frontend.Components
{
    public partial class ProveedoresTagsComponent
    {
        private List<Tags> Tags = [];
        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        protected override Task OnInitializedAsync()
        {
            Tags = TagsData.Todos;

            return Task.CompletedTask;
        }

        private void NavigateWithTag(string tagNombre)
        {
            var currentUri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            var query = System.Web.HttpUtility.ParseQueryString(currentUri.Query);

            query.Add("tags", tagNombre);

            var newQuery = query.ToString();
            NavigationManager.NavigateTo($"/search?{newQuery}");
        }
    }
}