namespace BibliotecaApiV2.Core.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"La entidad '{name}' con id '{key}' no fue encontrada.")
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }
    }
}
