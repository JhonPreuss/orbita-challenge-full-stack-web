using EducationGroup.Application.Dtos;
using System.Collections.Generic;

namespace EducationGroup.Application.Interfaces
{
    public interface IApplicationServicesCourses
    {
        void Add(CoursesDto coursesDto);
        void Update(CoursesDto coursesDto);
        void Remove(CoursesDto coursesDto);
        IEnumerable<CoursesDto> GetAll();
        CoursesDto GetById(int id);
    }
}
