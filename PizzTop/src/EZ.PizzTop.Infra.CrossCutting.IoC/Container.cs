using Ninject;

namespace EZ.PizzTop.Infra.CrossCutting.IoC
{
    public class Container
    {
        /*public Container()
        {
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(GetModule()));
        }*/

        public StandardKernel GetModule()
        {
            return new StandardKernel(new NinjectModulo(), new NinjectAppModulo());
        }
    }
}