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
    public class TipoAnuncioMapping : IEntityTypeConfiguration<TipoAnuncio>
    {
        public void Configure(EntityTypeBuilder<TipoAnuncio> builder)
        {

            builder.HasKey(t => t.Id);
            builder.Property(t => t.NomeTipoAnuncio)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(t => t.Duracao)
                .IsRequired()
                .HasColumnType("varchar(3)");

            builder.Property(t => t.Valor)
                .IsRequired()
                .HasColumnType("varchar(4)");

            builder.ToTable("TiposAnuncios");
        }
    }
}
