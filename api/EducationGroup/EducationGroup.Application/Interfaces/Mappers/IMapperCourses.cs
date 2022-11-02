using EducationGroup.Application.Dtos;
using EducationGroup.Domain.Entitys;
using System.Collections.Generic;

namespace EducationGroup.Application.Interfaces.Mappers
{
    public interface IMapperCourses
    {
        Courses MapperDtoToEntity(CoursesDto coursesDto);
        IEnumerable<CoursesDto> MapperListCoursesDto(IEnumerable<Courses> courses);
        CoursesDto MapperEntityToDto(Courses courses);
    }
}
