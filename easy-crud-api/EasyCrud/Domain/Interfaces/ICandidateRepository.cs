using EasyCrud.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EasyCrud.Domain.Interfaces
{
    public interface ICandidateRepository
	{
		Candidate Get(Guid id);

        IEnumerable<Candidate> GetAll();

		Candidate Insert(Candidate candidate);

		Candidate Update(Candidate candidate);
		
		void Delete(Candidate candidate);
	}
}
