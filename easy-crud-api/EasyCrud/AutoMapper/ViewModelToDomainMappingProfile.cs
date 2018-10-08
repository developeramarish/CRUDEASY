using AutoMapper;
using EasyCrud.Domain.Entities;
using EasyCrud.ViewModels;

namespace EasyCrud.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : this("Profile") { }

        protected ViewModelToDomainMappingProfile(string profileName) : base(profileName)
        {
            CreateMap<CandidateViewModel, Candidate>()
                .ForPath(dest => dest.Knowledge.Ionic, opt => opt.MapFrom(src => src.Ionic))
                .ForPath(dest => dest.Knowledge.Ios, opt => opt.MapFrom(src => src.Ios))
                .ForPath(dest => dest.Knowledge.Java, opt => opt.MapFrom(src => src.Java))
                 .ForPath(dest => dest.Knowledge.Illustrator, opt => opt.MapFrom(src => src.Illustrator))
                 .ForPath(dest => dest.Knowledge.Jquery, opt => opt.MapFrom(src => src.Jquery))
                 .ForPath(dest => dest.Knowledge.Others, opt => opt.MapFrom(src => src.Others))
                 .ForPath(dest => dest.Knowledge.Php, opt => opt.MapFrom(src => src.Php))
                  .ForPath(dest => dest.Knowledge.Photoshop, opt => opt.MapFrom(src => src.Photoshop))
                  .ForPath(dest => dest.Knowledge.Wordpress, opt => opt.MapFrom(src => src.Wordpress))
                  .ForPath(dest => dest.Knowledge.SqlServer, opt => opt.MapFrom(src => src.SqlServer))
                  .ForPath(dest => dest.Knowledge.Salesforce, opt => opt.MapFrom(src => src.Salesforce))
                  .ForPath(dest => dest.Knowledge.Python, opt => opt.MapFrom(src => src.Python))
                  .ForPath(dest => dest.Knowledge.Seo, opt => opt.MapFrom(src => src.Seo))
                  .ForPath(dest => dest.Knowledge.C, opt => opt.MapFrom(src => src.C))
                  .ForPath(dest => dest.Knowledge.Android, opt => opt.MapFrom(src => src.Android))
                  .ForPath(dest => dest.Knowledge.Angular, opt => opt.MapFrom(src => src.Angular))
                  .ForPath(dest => dest.Knowledge.Asp, opt => opt.MapFrom(src => src.Asp))
                  .ForPath(dest => dest.Knowledge.Css, opt => opt.MapFrom(src => src.Css))
                  .ForPath(dest => dest.Knowledge.Cplusplus, opt => opt.MapFrom(src => src.Cplusplus))
                  .ForPath(dest => dest.Knowledge.Django, opt => opt.MapFrom(src => src.Django))
                  .ForPath(dest => dest.Knowledge.Bootstrap, opt => opt.MapFrom(src => src.Bootstrap))
                  .ForPath(dest => dest.Knowledge.Ruby, opt => opt.MapFrom(src => src.Ruby))
                  .ForPath(dest => dest.Knowledge.MySql, opt => opt.MapFrom(src => src.MySql))
                   .ForPath(dest => dest.Knowledge.CandidateId, opt => opt.MapFrom(src => src.Id))
                   .ForPath(dest => dest.Knowledge.Id, opt => opt.MapFrom(src => src.KnowledgeId));

        }
    }
}
