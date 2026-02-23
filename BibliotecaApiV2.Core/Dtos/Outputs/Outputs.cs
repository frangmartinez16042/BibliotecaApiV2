namespace BibliotecaApiV2.Core.Dtos.Outputs
{
    public record AuthorOutput(string Id, string Name, string Description, bool Active, DateTimeOffset CreationData);
}
