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
    public class SubCategoriaMapping : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.NomeSubCategoria)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("SubCategorias");
        }
    }
}
