using Crud.Easy.Context;
using Crud.Easy.Domain.Repositories.Interfaces;
using NETCore.DapperKit.Extensions;
using System.Collections.Generic;

namespace Crud.Easy.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public CrudEasyContext db = new CrudEasyContext();

        public virtual bool Delete(T obj)
        {
            return db.Connection.Delete(obj);

        }

        public virtual T Get(long id)
        {
            return db.Connection.Get<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return db.Connection.GetAll<T>();
        }

        public virtual bool Insert(T obj)
        {
            var rows = db.Connection.Insert(obj);
            return rows > 0;
        }

        public virtual bool Update(T obj)
        {
            return db.Connection.Update(obj);
        }
    }
}
