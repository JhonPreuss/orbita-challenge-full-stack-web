using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces.Mappers;
using EducationGroup.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace EducationGroup.Application.Mappers
{
    public class MapperCourses : IMapperCourses
    {
        IEnumerable<CoursesDto> coursesDtos = new List<CoursesDto>();

        public Courses MapperDtoToEntity(CoursesDto coursesDto)
        {
            var courses = new Courses()
            {
                Id = coursesDto.Id,
                Name = coursesDto.Name,
                Active = coursesDto.Active,
            };
            return courses;
        }

        public CoursesDto MapperEntityToDto(Courses courses)
        {
            var coursesDto = new CoursesDto()
            {
                Id = courses.Id,
                Name = courses.Name,
                Active = courses.Active
            };
            return coursesDto;
        }

        public IEnumerable<CoursesDto> MapperListCoursesDto(IEnumerable<Courses> courses)
        {
            var dto = courses.Select(x =>
            new CoursesDto
            {
                Id = x.Id,
                Name = x.Name,
                Active = x.Active
            }
            );
            return dto;
        }
    }
}
