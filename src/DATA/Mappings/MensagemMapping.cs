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
    public class MensagemMapping : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.DS_Mensagem)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.ToTable("Mensagens");
        }
    }
}
