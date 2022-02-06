using AutoMapper;
using CourseLibrary.API.Models;

namespace CourseLibrary.API.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<Models.CourseDto, Entities.Course>();
        }
    }
}