using Microsoft.EntityFrameworkCore;
using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IQueryable<T> GetAllQueryable()
        {
            return entities
                        .Where(s => s.IsDeleted == false)
                        .OrderByDescending(s => s.CreationTime);
        }
        public async Task<T> GetById(int id)
        {
            return await entities.FirstOrDefaultAsync(s => s.Id == id && s.IsDeleted == false);
        }
        public async System.Threading.Tasks.Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.CreationTime = DateTime.Now;
            await entities.AddAsync(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                context.Entry(entity).State = EntityState.Detached;
            }
            entities.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
        public void DeleteRange(IQueryable<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.RemoveRange(entity);
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

    }
}
