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
    public class CandidateService : ServiceBase<Candidate> , ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(IRepositoryBase<Candidate> repository, ICandidateRepository candidateRepository) : base(repository)
        {
            _candidateRepository = candidateRepository;
        }

        public override bool Insert(Candidate obj, out string error)
        {
            if (obj.IsValid())
            {
                error = "Dados do candidado invalidos";
                return false;
            }
            error = "";
            return _candidateRepository.Insert(obj);
        }

        public override bool Update(Candidate obj, out string error)
        {
            if (!obj.IsValid())
            {
                error = "Candidado com dados inválidos";
                return false;
            }
            return base.Update(obj, out error);
        }
    }
}
