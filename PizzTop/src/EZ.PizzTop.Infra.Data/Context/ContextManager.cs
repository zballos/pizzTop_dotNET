using System.Web;
using EZ.PizzTop.Infra.Data.Interfaces;

namespace EZ.PizzTop.Infra.Data.Context
{
    public class ContextManager : IContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        // Padrão: One Context Per Request
        public PizzTopContext GetContext()
        {
            if (HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new PizzTopContext();
            }

            return (PizzTopContext) HttpContext.Current.Items[ContextKey];
        }
    }
}
