using AutoMapper;
using backend.Models;
using Media_Backend.Dtos;

namespace Media_Backend.Profiles
{
    //maak hier je profiles aan 
    public class UserProfile : Profile
    { 
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }

    }
}
