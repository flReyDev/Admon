using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminServices.IServices
{
    /// <summary>
    /// INterface CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrud<T>
    {
        T Get(int id);
        bool Add(T entity);
        void Delete(int id);
        void Update(T entity);
        void Update(T entity, int id);
    }
}
