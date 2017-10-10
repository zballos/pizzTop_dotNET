using System;
using EZ.PizzTop.Infra.Data.Context;
using EZ.PizzTop.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EZ.PizzTop.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzTopContext _dbContext;
        private bool _disposed;

        // será usado o ServiceLocator como injeção de dependência específica
        public UnitOfWork()
        {
            //var contextManager = new ContextManager().GetContext();
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager>();
            _dbContext = contextManager.GetContext();
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}