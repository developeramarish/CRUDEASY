using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Interfaces;
using EasyCrud.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    public class CandidatesController : Controller
    {
		private readonly ICandidateRepository _candidateRepository;
		public CandidatesController(ICandidateRepository candidateRepository)
		{
			_candidateRepository = candidateRepository;
		}

		// GET api/values
		[HttpGet]
		public IEnumerable<Candidate> Get()
		{
            return _candidateRepository.GetAll();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public Candidate Get(int id)
		{
            return _candidateRepository.Get();
        }

		// POST api/values
		[HttpPost]
		public void Post([FromBody] Candidate candidate)
		{
			_candidateRepository.Insert(candidate);
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put([FromBody] Candidate candidate, string id)
		{
            candidate.Id = new Guid(id);
            _candidateRepository.Update(candidate);
        }

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete([FromBody] Candidate candidate, string id)
		{
            candidate.Id = new Guid(id);
            _candidateRepository.Delete(candidate);
        }
	}
}
