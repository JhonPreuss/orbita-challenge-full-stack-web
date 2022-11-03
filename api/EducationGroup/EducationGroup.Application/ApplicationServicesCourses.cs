using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces;
using EducationGroup.Application.Interfaces.Mappers;
using EducationGroup.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace EducationGroup.Application
{
    public class ApplicationServicesCourses : IApplicationServicesCourses
    {
        private readonly IServicesCourses servicesCourses;
        private readonly IMapperCourses  mapperCourses;

        public ApplicationServicesCourses(IServicesCourses servicesCourses, IMapperCourses mapperCourses)
        {
            this.servicesCourses = servicesCourses;
            this.mapperCourses = mapperCourses;
        }

        public void Add(CoursesDto coursesDto)
        {
            var courses = mapperCourses.MapperDtoToEntity(coursesDto);
            servicesCourses.Add(courses);
        }

        public IEnumerable<CoursesDto> GetAll()
        {
            var courses = servicesCourses.GetAll();
            return mapperCourses.MapperListCoursesDto(courses);
        }

        public CoursesDto GetById(int id)
        {
            var courses = servicesCourses.GetById(id).Result;
            return mapperCourses.MapperEntityToDto(courses);
        }

        public void Remove(CoursesDto coursesDto)
        {
            var courses = mapperCourses.MapperDtoToEntity(coursesDto);
            servicesCourses.Remove(courses);
        }

        public void Update(CoursesDto coursesDto)
        {
            var courses = mapperCourses.MapperDtoToEntity(coursesDto);
            servicesCourses.Update(courses);
        }
    }
}
