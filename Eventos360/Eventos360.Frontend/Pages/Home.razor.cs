using Eventos360.Frontend.Data;
using Eventos360.Shared.DTOs;
using Eventos360.Shared.Entities;

namespace Eventos360.Frontend.Pages
{
    public partial class Home
    {

        //Logica carga una lista de categoria y que cada categoria tenga su top de proveedores
        private List<Proveedor> Top10Proveedores = [];

        protected override void OnInitialized()
        {
            Top10Proveedores = ProveedoresData.Todos;
        }
    }
}