using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Repositories.Interfaces
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        void Add(Employee employee);
    }
}
