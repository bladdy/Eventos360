namespace Eventos360.Frontend.Components
{
    public partial class ContactFormComponent
    {
        private ContactModel model = new();

        private void Enviar()
        {
            // Aquí conectas API, email o WhatsApp
            Console.WriteLine($"Mensaje de {model.Nombre} - {model.Correo}");
        }

        class ContactModel
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Mensaje { get; set; }
        }
    }
}