using AutoMapper;
using EasyCrud.Domain.Entities;
using EasyCrud.Domain.Interfaces;
using EasyCrud.Domain.Validators;
using EasyCrud.Repositories;
using EasyCrud.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
		public IEnumerable<CandidateViewModel> Get()
		{
            var candidates = _candidateRepository.GetAll();
            var candidatesVM = Mapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateViewModel>>(candidates);
            return candidatesVM;
        }

		// GET api/values/5
		[HttpGet("{id}")]
		public CandidateViewModel Get(Guid id)
		{
            var candidate =  _candidateRepository.Get(id);
            var candidateVM = Mapper.Map<Candidate, CandidateViewModel>(candidate);
            return candidateVM;
        }

		// POST api/values
		[HttpPost]
		public IActionResult Post([FromBody] CandidateViewModel candidateVM)
		{
            var candidate = Mapper.Map<CandidateViewModel, Candidate>(candidateVM);

            var validator = new CandidateValidator();
            var result = validator.Validate(candidate);


            if (result.IsValid)
            {
                _candidateRepository.Insert(candidate);
                return Ok();
            }
            else
            {
                return BadRequest(result.Errors);
            }
            
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public IActionResult Put([FromBody] CandidateViewModel candidateVM, string id)
		{
            candidateVM.Id = new Guid(id);
            var candidate = Mapper.Map<CandidateViewModel, Candidate>(candidateVM);

            var validator = new CandidateValidator();
            var result = validator.Validate(candidate);


            if (result.IsValid)
            {
                _candidateRepository.Update(candidate);
                return Ok();
            } else
            {
                return Json(result.Errors);
            }         
        }

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(Guid id)
		{
           var candidate =  _candidateRepository.Get(id);
            _candidateRepository.Delete(candidate);
        }
	}
}
