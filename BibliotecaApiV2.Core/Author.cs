namespace BibliotecaApiV2.Core
{
    public class Author 
    {
        public Author(string name, string? description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Active = true;
            CreationData = DateTimeOffset.Now;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
        public DateTimeOffset CreationData { get; set; }
    }
}
