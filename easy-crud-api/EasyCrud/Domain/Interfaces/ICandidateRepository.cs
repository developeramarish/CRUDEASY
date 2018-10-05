using EasyCrud.Domain.Entities;
using System.Collections.Generic;

namespace EasyCrud.Domain.Interfaces
{
    public interface ICandidateRepository
	{
		Candidate Get(params object[] keyValues);

        IEnumerable<Candidate> GetAll();

		Candidate Insert(Candidate candidate);

		Candidate Update(Candidate candidate);
		
		void Delete(Candidate candidate);
	}
}
