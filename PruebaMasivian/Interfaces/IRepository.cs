using PruebaMasivian.Models;
using System.Collections.Generic;
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
