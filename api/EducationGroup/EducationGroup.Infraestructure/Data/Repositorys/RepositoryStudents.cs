using EducationGroup.Domain.Core.Interfaces.Repositorys;
using EducationGroup.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationGroup.Infraestructure.Data.Repositorys
{
    public class RepositoryStudents : RepositoryBase<Students>, IRepositoryStudents
    {
        private readonly SqlContext sqlContext;

        public RepositoryStudents(SqlContext sqlContext) : base (sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
