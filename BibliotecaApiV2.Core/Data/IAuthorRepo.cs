namespace BibliotecaApiV2.Core.Data
{
    public interface IAuthorRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task AddAsync(Author author);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transferId"></param>
        /// <param name="distributionCenterId"></param>
        /// <returns></returns>
        Task<Author?> GetById(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task SaveChanges();
    }
}
