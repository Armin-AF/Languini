using AutoMapper;
using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;

namespace LanguageFika.Api;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile(){
        CreateMap<User, UserViewModel>();
        CreateMap<Meeting, MeetingViewModel>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
            .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language))
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
    }
}