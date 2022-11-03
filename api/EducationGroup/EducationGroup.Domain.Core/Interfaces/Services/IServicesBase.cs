using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationGroup.Domain.Core.Interfaces.Services
{
    public interface IServicesBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
    }
}
