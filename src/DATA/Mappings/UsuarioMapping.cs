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
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(u => u.Telefone)
                .IsRequired()
                .HasColumnType("varchar(13)");


            builder.ToTable("Usuarios");
        }
    }
}
