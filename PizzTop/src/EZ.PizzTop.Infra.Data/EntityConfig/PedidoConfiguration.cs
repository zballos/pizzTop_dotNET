using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Infra.Data.EntityConfig
{
    class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasKey(p => p.PedidoId);

            //Property(p => p.Nome)
            //    .IsRequired()
            //    .HasMaxLength(150);
            
            Property(p => p.ValorTotal)
                .IsRequired();
            
            HasRequired(e => e.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(e => e.ClienteId);

            HasMany(t => t.Produtos)
                .WithMany(t => t.Pedidos)
                .Map(m =>
                {
                    m.ToTable("PedidoProdutos");
                    m.MapLeftKey("PedidoId");
                    m.MapRightKey("ProdutoId");
                });

            ToTable("Pedidos");
        }
    }
}
