using EducationGroup.Application.Dtos;
using EducationGroup.Domain.Entitys;
using System.Collections.Generic;

namespace EducationGroup.Application.Interfaces.Mappers
{
    public interface IMapperStudents
    {
        //metodos para fazer o mapeamento da entidade para dto
        Students MapperDtoToEntity(StudentsDto studentsDto);
        IEnumerable<StudentsDto> MapperListStudentsDto(IEnumerable<Students> students);
        StudentsDto MapperEntityToDto(Students students);

    }
}
