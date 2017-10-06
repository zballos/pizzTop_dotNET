using EZ.PizzTop.Infra.Data.Context;

namespace EZ.PizzTop.Infra.Data.Interfaces
{
    public interface IContextManager
    {
        PizzTopContext GetContext();
    }
}
