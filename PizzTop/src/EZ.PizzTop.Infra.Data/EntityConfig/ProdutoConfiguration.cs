using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Descricao)
                .HasMaxLength(500);

            Property(p => p.Valor)
                .IsRequired();
            
            HasRequired(p => p.TipoProduto)
                .WithRequiredPrincipal(t => t.Produto);

            //HasRequired(p => p.Pedido)
            //    .WithMany(c => c.Produtos)
            //    .HasForeignKey(p => p.ProdutoId);

            ToTable("Produtos");
        }
    }
}
