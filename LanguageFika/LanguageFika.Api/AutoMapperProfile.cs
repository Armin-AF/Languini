using AutoMapper;
using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;

namespace LanguageFika.Api;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile(){
        CreateMap<User, UserViewModel>();
    }
}