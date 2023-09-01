using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIDAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //TRUE YADA FALSE DÖNECEK, LAMBDA KISMINDA YAZILAN SORGU SONUCUNDA VARMI YOKMU DÖNER

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entites);

        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entites);
    }
}
