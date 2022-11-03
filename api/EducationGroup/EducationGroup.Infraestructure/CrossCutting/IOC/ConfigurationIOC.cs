using Autofac;
using EducationGroup.Application;
using EducationGroup.Application.Interfaces;
using EducationGroup.Application.Interfaces.Mappers;
using EducationGroup.Application.Mappers;
using EducationGroup.Domain.Core.Interfaces.Repositorys;
using EducationGroup.Domain.Core.Interfaces.Services;
using EducationGroup.Domain.Services;
using EducationGroup.Infraestructure.Data.Repositorys;

namespace EducationGroup.Infraestructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServicesStudents>().As<IApplicationServicesStudents>();
            builder.RegisterType<ApplicationServicesCourses>().As<IApplicationServicesCourses>();

            builder.RegisterType<ServicesStudents>().As<IServicesStudents>();
            builder.RegisterType<ServicesCourses>().As<IServicesCourses>();

            builder.RegisterType<RepositoryStudents>().As<IRepositoryStudents>();
            builder.RegisterType<RepositoryCourses>().As<IRepositoryCourses>();

            builder.RegisterType<MapperStudents>().As<IMapperStudents>();
            builder.RegisterType<MapperCourses>().As<IMapperCourses>();
            #endregion
        }
    }
}
