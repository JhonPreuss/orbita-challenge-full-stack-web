using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces;
using EducationGroup.Application.Interfaces.Mappers;
using EducationGroup.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace EducationGroup.Application
{
    public class ApplicationServicesStudents : IApplicationServicesStudents
    {

        private readonly IServicesStudents serviceStudents;
        private readonly IMapperStudents mapperStudents;

        public ApplicationServicesStudents(IServicesStudents serviceStudents, IMapperStudents mapperStudents)
        {
            this.serviceStudents = serviceStudents;
            this.mapperStudents = mapperStudents;
        }

        public void Add(StudentsDto studentsDto)
        {
            var students = mapperStudents.MapperDtoToEntity(studentsDto);
            serviceStudents.Add(students);
        }

        public IEnumerable<StudentsDto> GetAll()
        {
            var students = serviceStudents.GetAll();
            return mapperStudents.MapperListStudentsDto(students);
        }

        public StudentsDto GetById(int id)
        {
            var students = serviceStudents.GetById(id);
            return mapperStudents.MapperEntityToDto(students);
        }

        public void Remove(StudentsDto studentsDto)
        {
            var students = mapperStudents.MapperDtoToEntity(studentsDto);
            serviceStudents.Remove(students);
        }

        public void Update(StudentsDto studentsDto)
        {
            var students = mapperStudents.MapperDtoToEntity(studentsDto);
            serviceStudents.Remove(students);
        }
    }
}
