using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        bool Insert(T obj, out  string error);

        bool Delete(T obj);

        bool Update(T obj, out string error);

        T Get(long id);

        IEnumerable<T> GetAll();
    }
}
