﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EZ.PizzTop.Domain.Interfaces.Repository
{
    // T ou TEntity
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);

        TEntity ObterPorId(Guid id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity obj);

        void Remover(Guid id);

        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

        int SaveChanges();
    }
}
