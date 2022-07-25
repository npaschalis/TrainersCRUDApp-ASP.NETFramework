using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TrainersCRUDApp.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);

        // Update isn't included in the interface because unlike create & remove, every model has a different update logic. 
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        void Save();
    }
}
