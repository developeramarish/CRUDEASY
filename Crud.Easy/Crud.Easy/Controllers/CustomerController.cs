using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Easy.Domain.Entities;
using Crud.Easy.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Easy.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAll();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Customer")]
        public Customer Get(int id)
        {
            return _customerService.Get(id);
        }
        
        // POST: api/Customer
        [HttpPost]
        public ActionResult Post([FromBody]Customer customer)
        {
            string error = string.Empty;
            if (_customerService.Insert(customer, out error))
            {
                return StatusCode(200, Json("Cliente criado com sucesso"));
            }
            else if (!string.IsNullOrWhiteSpace(error))
            {
                return StatusCode(500, Json(error));
            }
            else
            {
                return StatusCode(500, Json("Erro ao criar cliente"));
            }

        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            string error = string.Empty;
            customer.CustomerId = id;
            if (_customerService.Update(customer, out error))
            {
                return StatusCode(200, Json("Cliente alterado com sucesso"));
            }
            else if (!string.IsNullOrWhiteSpace(error))
            {
                return StatusCode(500, Json(error));
            }
            else
            {
                return StatusCode(500, Json("Erro ao alterar cliente"));
            }
           
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var customer = _customerService.Get(id);
            if (_customerService.Delete(customer))
            {
                return StatusCode(200, Json("Cliente deletado com sucesso"));
            }
            else
            {
                return StatusCode(200, Json("Erro ao deletar cliente"));
            }
        }
    }
}
