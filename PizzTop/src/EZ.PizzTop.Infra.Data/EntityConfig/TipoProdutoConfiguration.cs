using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZ.PizzTop.Domain.Entities;

namespace EZ.PizzTop.Infra.Data.EntityConfig
{
    public class TipoProdutoConfiguration : EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoConfiguration()
        {
            HasKey(t => t.TipoProdutoId);

            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(150);

            ToTable("TiposDeProduto");
        }
    }
}
