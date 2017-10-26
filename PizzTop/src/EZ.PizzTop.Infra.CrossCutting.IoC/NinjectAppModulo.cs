using EZ.PizzTop.Application;
using EZ.PizzTop.Application.Interface;
using Ninject.Modules;

namespace EZ.PizzTop.Infra.CrossCutting.IoC
{
    public class NinjectAppModulo : NinjectModule
    {
        public override void Load()
        {
            // Application
            Bind<IClienteAppService>().To<ClienteAppService>();
        }
    }
}