namespace BibliotecaApiV2.Core.Data
{
    public interface IAuthorRepo : IBaseRepo<string,Author>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task AddAsync(Author author);
    }
}
