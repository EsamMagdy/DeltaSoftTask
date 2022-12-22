using OA_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repo
{
    public interface IUnitOfWork
    {
        Repository<OA_Data.Task> Tasks { get; }
        public Task<bool> Complete();
    }
}
