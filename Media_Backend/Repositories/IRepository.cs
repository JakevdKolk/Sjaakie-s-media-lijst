using System.Collections.Generic;
namespace Media_Backend.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<List<T>> All();
        IRepository<T> GetById(int id);   
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();    



    }
}
