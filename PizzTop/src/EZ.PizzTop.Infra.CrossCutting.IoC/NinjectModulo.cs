using EZ.PizzTop.Application;
using EZ.PizzTop.Application.Interface;
using EZ.PizzTop.Domain.Interfaces.Repository;
using EZ.PizzTop.Domain.Interfaces.Services;
using EZ.PizzTop.Domain.Services;
using EZ.PizzTop.Infra.Data.Repository;
using Ninject.Modules;

namespace EZ.PizzTop.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // app
            Bind<IClienteAppService>().To<ClienteAppService>();

            // domain
            Bind<IClienteService>().To<ClienteService>();

            // data
            Bind<IClienteRepository>().To<ClienteRepository>();
        }
    }
}