namespace BibliotecaApiV2.Core.Data
{
    public interface IBaseRepo<TKey, TEntity> where TEntity : class
    {
        /// <summary>
        /// Guarda los cambios
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();

        // <summary>
        /// Obtiene una entidad por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity?> GetByIdAsync(TKey id);
    }
}
