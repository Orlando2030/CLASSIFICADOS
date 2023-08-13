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
    public class ModeloMapping : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.NomeModelo)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Modelos");
        }
    }
}
