using AutoMapper;
using EasyCrud.Domain.Entities;
using EasyCrud.ViewModels;

namespace EasyCrud.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : this("Profile") { }

        protected DomainToViewModelMappingProfile(string profileName) : base(profileName)
        {
            CreateMap<Candidate, CandidateViewModel > ()
                .ForPath(dest => dest.Ionic, opt => opt.MapFrom(src => src.Knowledge.Ionic))
                .ForPath(dest => dest.Ios, opt => opt.MapFrom(src => src.Knowledge.Ios))
                .ForPath(dest => dest.Java, opt => opt.MapFrom(src => src.Knowledge.Java))
                 .ForPath(dest => dest.Illustrator, opt => opt.MapFrom(src => src.Knowledge.Illustrator))
                 .ForPath(dest => dest.Jquery, opt => opt.MapFrom(src => src.Knowledge.Jquery))
                 .ForPath(dest => dest.Others, opt => opt.MapFrom(src => src.Knowledge.Others))
                 .ForPath(dest => dest.Php, opt => opt.MapFrom(src => src.Knowledge.Php))
                  .ForPath(dest => dest.Photoshop, opt => opt.MapFrom(src => src.Knowledge.Photoshop))
                  .ForPath(dest => dest.Wordpress, opt => opt.MapFrom(src => src.Knowledge.Wordpress))
                  .ForPath(dest => dest.SqlServer, opt => opt.MapFrom(src => src.Knowledge.SqlServer))
                  .ForPath(dest => dest.Salesforce, opt => opt.MapFrom(src => src.Knowledge.Salesforce))
                  .ForPath(dest => dest.Python, opt => opt.MapFrom(src => src.Knowledge.Python))
                  .ForPath(dest => dest.Seo, opt => opt.MapFrom(src => src.Knowledge.Seo))
                  .ForPath(dest => dest.C, opt => opt.MapFrom(src => src.Knowledge.C))
                  .ForPath(dest => dest.Android, opt => opt.MapFrom(src => src.Knowledge.Android))
                  .ForPath(dest => dest.Angular, opt => opt.MapFrom(src => src.Knowledge.Angular))
                  .ForPath(dest => dest.Asp, opt => opt.MapFrom(src => src.Knowledge.Asp))
                  .ForPath(dest => dest.Css, opt => opt.MapFrom(src => src.Knowledge.Css))
                  .ForPath(dest => dest.Cplusplus, opt => opt.MapFrom(src => src.Knowledge.Cplusplus))
                  .ForPath(dest => dest.Django, opt => opt.MapFrom(src => src.Knowledge.Django))
                  .ForPath(dest => dest.Bootstrap, opt => opt.MapFrom(src => src.Knowledge.Bootstrap))
                  .ForPath(dest => dest.Ruby, opt => opt.MapFrom(src => src.Knowledge.Ruby))
                  .ForPath(dest => dest.MySql, opt => opt.MapFrom(src => src.Knowledge.MySql))
                   .ForPath(dest => dest.KnowledgeId, opt => opt.MapFrom(src => src.Knowledge.Id));
        }
    }
}
