using PruebaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasivian.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IList<T> ListAll();
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
