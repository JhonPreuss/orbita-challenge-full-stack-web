using EducationGroup.Domain.Core.Interfaces.Repositorys;
using EducationGroup.Domain.Core.Interfaces.Services;
using EducationGroup.Domain.Entitys;

namespace EducationGroup.Domain.Services
{
    public class ServicesStudents : ServicesBase<Students>, IServicesStudents
    {
        private readonly IRepositoryStudents repositoryStudents;

        public ServicesStudents(IRepositoryStudents repositoryStudents) : base(repositoryStudents)
        {
            this.repositoryStudents = repositoryStudents;
        }
    }
}
