using EducationGroup.Domain.Core.Interfaces.Repositorys;
using EducationGroup.Domain.Core.Interfaces.Services;
using EducationGroup.Domain.Entitys;

namespace EducationGroup.Domain.Services
{
    public class ServicesCourses : ServicesBase<Courses>, IServicesCourses
    {
        private readonly IRepositoryCourses repositoryCourses;

        public ServicesCourses(IRepositoryCourses repositoryCourses) :base(repositoryCourses)
        {
            this.repositoryCourses = repositoryCourses;
        }
    }
}
