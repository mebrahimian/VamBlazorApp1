using AutoMapper;
using VamBlazor.Client.Domain.Entities;
using VamBlazor.Client.Application.Dtos;


namespace VamBlazor.Client.Application.Mappings
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();

        }
    }
    public class PersonAccountProfile : Profile
    {
        public PersonAccountProfile()
        {
            CreateMap<Hesab, PersonAccountDto>().ReverseMap()
            .ForMember(dest => dest.IdDi, opt => opt.MapFrom(src => src.Moaref));

        }
    }
    public class PersonQVamProfile : Profile
    {
        public PersonQVamProfile()
        {
            CreateMap<Qvam, PersonQVamDto > ().ReverseMap()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.TypeVam));

        }
    }
    public class PersonPVamProfile : Profile
    {
        public PersonPVamProfile()
        {
            CreateMap<Pvam, PersonPVamDto>().ReverseMap();
            
        }
    }
    public class PersonFullDataProfile : Profile
    {
        public PersonFullDataProfile()
        {
            CreateMap<vwPersonFullData, PersonFullDataDto>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
            .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
            .ForMember(dest => dest.HesabNo, opt => opt.MapFrom(src => src.HesabNo))
            .ForMember(dest => dest.QReqNo, opt => opt.MapFrom(src => src.QReqNo))
            .ForMember(dest => dest.QDate, opt => opt.MapFrom(src => src.QDate));

        }
    }

    public class PardarProfile : Profile
    {
        public PardarProfile()
        {
            CreateMap<Pardar, PardarDto>().ReverseMap();

        }
    }



}