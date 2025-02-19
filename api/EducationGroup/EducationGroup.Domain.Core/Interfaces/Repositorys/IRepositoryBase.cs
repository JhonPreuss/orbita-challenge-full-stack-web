﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EducationGroup.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();//lista de leitura
        Task<TEntity> GetById(int id);
    }
}
