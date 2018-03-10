using Crud.Easy.Domain.Entities;
using Crud.Easy.Domain.Interfaces.Repositories;
using Crud.Easy.Domain.Interfaces.Services;
using Crud.Easy.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Services
{
    public class CustomerService : ServiceBase<Customer> , ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(IRepositoryBase<Customer> repository, ICustomerRepository customerRepository) : base(repository)
        {
            _customerRepository = customerRepository;
        }

        public override bool Insert(Customer obj, out string error)
        {
            if (!obj.IsValid())
            {
                error = "Dados do cliente invalidos";
                return false;
            }
            error = "";
            return base.Insert(obj, out error);
        }

        public override bool Update(Customer obj, out string error)
        {
            if (!obj.IsValid())
            {
                error = "Cliente com dados inválidos";
                return false;
            }
            return base.Update(obj, out error);
        }
    }
}
