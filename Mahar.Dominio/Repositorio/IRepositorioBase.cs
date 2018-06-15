using System;
using System.Collections.Generic;

namespace Mahar.Dominio.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(Int64 id);

        IList<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

        void Save(TEntity obj);
    }
}
