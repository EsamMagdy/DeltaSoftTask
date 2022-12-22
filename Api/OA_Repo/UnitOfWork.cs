using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repo
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly ApplicationContext _context;
        public Repository<OA_Data.Task> Tasks { get; set; }
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Tasks = new Repository<OA_Data.Task>(context);
        }
        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
