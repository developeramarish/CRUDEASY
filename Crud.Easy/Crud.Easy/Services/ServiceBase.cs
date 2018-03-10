using Crud.Easy.Domain.Interfaces.Services;
using Crud.Easy.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Services
{
    public class ServiceBase<T> : IServiceBase<T> where  T : class
    {
        // Aqui precisa fazer o Injeção de Dependencia
        readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Delete(T obj)
        {
            return _repository.Delete(obj);
        }

        public virtual T Get(long id)
        {
            return _repository.Get(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual bool Insert(T obj, out string error)
        {
            error = "";
            return _repository.Insert(obj);
        }

        public virtual bool Update(T obj, out string error)
        {
            error = "";
            return _repository.Update(obj);
        }
    }
}
