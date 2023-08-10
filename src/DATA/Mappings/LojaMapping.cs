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
    public class LojaMapping : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(l => l.Descricao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(l => l.Email)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(u => u.Telefone)
                .IsRequired()
                .HasColumnType("varchar(13)");

            builder.Property(u => u.Whatsapp)
                .IsRequired()
                .HasColumnType("varchar(13)");

            builder.Property(l => l.Rua)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(l => l.Bairro)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(l => l.Cidade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(l => l.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(l => l.Cep)
                .IsRequired()
                .HasColumnType("varchar(9)");

            builder.ToTable("Lojas");
        }
    }
}
