using BUSINESS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Mappings
{
    public class AnuncioMapping : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomeAnuncio)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Valor_Antigo)
                .IsRequired();

            builder.Property(c => c.Valor)
                .IsRequired();

            builder.Property(c => c.Imagem)
                .IsRequired();

            builder.Property(c => c.Status)
                .IsRequired();

            builder.ToTable("Anuncios");
        }
    }
}
