using AutoMapper;
using WorkoutTimeAPI.Dtos;
using WorkoutTimeAPI.Models;

namespace WorkoutTimeAPI.Profiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile() {
            CreateMap<Exercise, ExerciseDto>().ReverseMap();
        }
    }
}
