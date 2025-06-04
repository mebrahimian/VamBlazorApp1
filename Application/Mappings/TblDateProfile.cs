using AutoMapper;
using VamBlazor.Client.Domain.Entities;
using VamBlazor.Client.Application.Dtos;
using System.Data;


namespace VamBlazor.Client.Application.Mappings
{
    public class TblDateProfile : Profile
    {
        public TblDateProfile()
        {
            CreateMap<IDataReader, tblDate>()
           .ForMember(dest => dest.HDate, opt => opt.MapFrom(src => src["HDate"]))
           .ForMember(dest => dest.GDate, opt => opt.MapFrom(src => src["GDate"]))
           .ForMember(dest => dest.HYear, opt => opt.MapFrom(src => src["HYear"]))
           .ForMember(dest => dest.GYear, opt => opt.MapFrom(src => src["GYear"]))
           .ForMember(dest => dest.HYrMth, opt => opt.MapFrom(src => src["HYrMth"]))
           .ForMember(dest => dest.GYrMth, opt => opt.MapFrom(src => src["GYrMth"]))
           .ForMember(dest => dest.HMonthNo, opt => opt.MapFrom(src => src["HMonthNo"]))
           .ForMember(dest => dest.GMonthNo, opt => opt.MapFrom(src => src["GMonthNo"]))
           .ForMember(dest => dest.HMonthName, opt => opt.MapFrom(src => src["HMonthName"]))
           .ForMember(dest => dest.GMonthName, opt => opt.MapFrom(src => src["GMonthName"]))
           .ForMember(dest => dest.HWeekNo, opt => opt.MapFrom(src => src["HWeekNo"]))
           .ForMember(dest => dest.GWeekNo, opt => opt.MapFrom(src => src["GWeekNo"]))
           .ForMember(dest => dest.HDay, opt => opt.MapFrom(src => src["HDay"]))
           .ForMember(dest => dest.GDay, opt => opt.MapFrom(src => src["GDay"]))
           .ForMember(dest => dest.HMonthLen, opt => opt.MapFrom(src => src["HMonthLen"]))
           .ForMember(dest => dest.GMonthLen, opt => opt.MapFrom(src => src["GMonthLen"]))
           .ForMember(dest => dest.HWeekDayName, opt => opt.MapFrom(src => src["HWeekDayName"]))
           .ForMember(dest => dest.GWeekDayName, opt => opt.MapFrom(src => src["GWeekDayName"]))
           .ForMember(dest => dest.HWeekDayNo, opt => opt.MapFrom(src => src["GWeekDayNo"]))
           .ForMember(dest => dest.GWeekDayNo, opt => opt.MapFrom(src => src["GWeekDayNo"]))
           .ForMember(dest => dest.DayName, opt => opt.MapFrom(src => src["DayName"]));
        }
    }
 }