using EducationGroup.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationGroup.Application.Interfaces
{
    public interface IApplicationServicesStudents
    {
        void Add(StudentsDto studentsDto);
        void Update(StudentsDto studentsDto);
        void Remove(StudentsDto studentsDto);
        IEnumerable<StudentsDto> GetAll();
        Task<StudentsDto> GetById(int id);
    }
}

