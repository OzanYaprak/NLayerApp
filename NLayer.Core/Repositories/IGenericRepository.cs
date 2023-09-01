using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIDAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //TRUE YADA FALSE DÖNECEK, LAMBDA KISMINDA YAZILAN SORGU SONUCUNDA VARMI YOKMU DÖNER

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entites);

        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entites);
    }
}
