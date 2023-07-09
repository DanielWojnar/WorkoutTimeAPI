using AutoMapper;
using WorkoutTimeAPI.Dtos;
using WorkoutTimeAPI.Models;

namespace WorkoutTimeAPI.Profiles
{
    public class WorkoutProfile : Profile
    {
        public WorkoutProfile()
        {
            CreateMap<Workout, WorkoutDto>().ReverseMap();
        }
    }
}
