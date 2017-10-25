﻿using EZ.PizzTop.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace EZ.PizzTop.Application
{
    public class AppService
    {
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }
    }
}