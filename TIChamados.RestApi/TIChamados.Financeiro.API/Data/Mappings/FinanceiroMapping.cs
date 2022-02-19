using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace TIChamados.Financeiro.API.Data.Mappings
{
    public class FinanceiroMapping : IEntityTypeConfiguration<Models.Financeiro>
    {
        public void Configure(EntityTypeBuilder<Models.Financeiro> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");            

            builder.Property(f => f.CreatedAt)
                .IsRequired()                
                .HasDefaultValue(DateTime.Now);

            builder.ToTable("Financeiro");
        }
    }
}
