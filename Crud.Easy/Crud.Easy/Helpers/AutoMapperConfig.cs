using AutoMapper;
using Crud.Easy.Domain.Entities;
using Crud.Easy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Easy.Helpers
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Candidate, CandidateViewModel>()
                .ReverseMap();

            CreateMap<Bank, CandidateViewModel>()
                  .ForMember(d => d.BankName, opt => opt.MapFrom(s => s.Name))
                  .ForMember(d => d.CPFRecipient, opt => opt.MapFrom(s => s.CPFRecipient)).ReverseMap();

            CreateMap<Knowledgement, CandidateViewModel>()
                .ReverseMap();


        }
    }
}
