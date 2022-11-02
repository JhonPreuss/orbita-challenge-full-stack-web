using EducationGroup.Application.Dtos;
using EducationGroup.Application.Interfaces.Mappers;
using EducationGroup.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace EducationGroup.Application.Mappers
{
    public class MapperStudents : IMapperStudents
    {
        IEnumerable<StudentsDto> studentsDto = new List<StudentsDto>();
        public Students MapperDtoToEntity(StudentsDto studentsDto)
        {
            var students = new Students()
            {
                Id = studentsDto.Id,
                Name = studentsDto.Name,
                Email = studentsDto.Email,
                Cpf = studentsDto.Cpf,
                AcademicRecord = studentsDto.AcademicRecord,
                Active = studentsDto.Active
            };
            return students;
        }


        public StudentsDto MapperEntityToDto(Students students)
        {
            var studentsDto = new StudentsDto()
            {
                Id = students.Id,
                Name = students.Name,
                Email = students.Email,
                Cpf = students.Cpf,
                AcademicRecord = students.AcademicRecord,
                Active = students.Active
            };
            return studentsDto;
        }

        public IEnumerable<StudentsDto> MapperListStudentsDto(IEnumerable<Students> students)
        {
            var dto = students.Select(x =>
            new StudentsDto
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Cpf = x.Cpf,
                AcademicRecord = x.AcademicRecord,
                Active = x.Active
            }
            );
            return dto;
        }

    }
}
