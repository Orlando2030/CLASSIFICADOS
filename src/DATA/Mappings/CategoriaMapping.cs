using BUSINESS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeCategoria)
                .IsRequired()
                .HasColumnType("varchar(200)");

            // 1 : N => Categotia : SubCategotia
            builder.HasMany(c => c.SubCategoria)
                .WithOne(s => s.Categoria)
                .HasForeignKey(s => s.ID_Categoria);

            builder.ToTable("Categorias");

        }
    }
}


