using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FatKiller.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> GetWhere(Func<T, bool> predicate);

        T GetById(Guid id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int Count(Func<T, bool> predicate);
    }
}