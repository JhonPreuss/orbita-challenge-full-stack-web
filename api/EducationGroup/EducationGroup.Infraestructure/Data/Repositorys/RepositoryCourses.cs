using EducationGroup.Domain.Core.Interfaces.Repositorys;
using EducationGroup.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationGroup.Infraestructure.Data.Repositorys
{
    public class RepositoryCourses : RepositoryBase<Courses>, IRepositoryCourses
    {
        private readonly SqlContext sqlContext;

        public RepositoryCourses(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
