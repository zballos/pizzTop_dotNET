using EZ.PizzTop.Application;
using EZ.PizzTop.Application.Interface;
using EZ.PizzTop.Domain.Interfaces.Repository;
using EZ.PizzTop.Domain.Interfaces.Services;
using EZ.PizzTop.Domain.Services;
using EZ.PizzTop.Infra.Data.Context;
using EZ.PizzTop.Infra.Data.Interfaces;
using EZ.PizzTop.Infra.Data.Repository;
using EZ.PizzTop.Infra.Data.UoW;
using Ninject.Modules;

namespace EZ.PizzTop.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {           
            // domain
            Bind<IClienteService>().To<ClienteService>();

            // data
            Bind<IClienteRepository>().To<ClienteRepository>();

            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IContextManager>().To<ContextManager>();
        }
    }
}