using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repo
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAllQueryable();
        Task<T> GetById(int id);
        Task Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IQueryable<T> entity);
        void Remove(T entity);
    }
}
