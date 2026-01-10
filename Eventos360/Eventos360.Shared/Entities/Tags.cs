namespace Eventos360.Shared.Entities
{
    public class Tags
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<TagsProvedor> TagsProvedors { get; set; }
    }
}