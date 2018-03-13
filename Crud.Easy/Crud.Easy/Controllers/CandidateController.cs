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
    [Route("api/Candidate")]
    public class CandidateController : Controller
    {

        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

      
        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return _candidateService.GetAll();
        }

       
        [HttpGet("{id}", Name = "Candidate")]
        public Candidate Get(int id)
        {
            return _candidateService.Get(id);
        }
        
       
        [HttpPost]
        public ActionResult Post([FromBody]Candidate candidate)
        {
            string error = string.Empty;
            if (_candidateService.Insert(candidate, out error))
            {
                return StatusCode(200, Json("candidate criado com sucesso"));
            }
            else if (!string.IsNullOrWhiteSpace(error))
            {
                return StatusCode(500, Json(error));
            }
            else
            {
                return StatusCode(500, Json("Erro ao criar candidato"));
            }

        }

       
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Candidate candidate)
        {
            string error = string.Empty;
            candidate.CandidateId = id;
            if (_candidateService.Update(candidate, out error))
            {
                return StatusCode(200, Json("candidato alterado com sucesso"));
            }
            else if (!string.IsNullOrWhiteSpace(error))
            {
                return StatusCode(500, Json(error));
            }
            else
            {
                return StatusCode(500, Json("Erro ao alterar candidato"));
            }
           
        }
        
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var candidate = _candidateService.Get(id);
            if (_candidateService.Delete(candidate))
            {
                return StatusCode(200, Json("candidato deletado com sucesso"));
            }
            else
            {
                return StatusCode(200, Json("Erro ao deletar candidato"));
            }
        }
    }
}
