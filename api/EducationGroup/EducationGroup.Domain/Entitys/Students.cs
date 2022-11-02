using System;

namespace EducationGroup.Domain.Entitys
{
    public class Students : Base
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string AcademicRecord { get; set; }
        public bool Active { get; set; }
    }
}
