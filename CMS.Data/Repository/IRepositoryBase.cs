using CMS.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Delete(int id);
        TEntity Insert(TEntity entity);
        int InsertAndGetId(TEntity entity);
        void Update(TEntity entity);
    }
}
