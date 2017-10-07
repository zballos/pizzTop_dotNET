using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZ.PizzTop.Domain.Entities
{
    public class TipoProduto
    {
        public TipoProduto()
        {
            TipoProdutoId = Guid.NewGuid();
        }

        public Guid TipoProdutoId { get; set; }
        public string Nome { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
