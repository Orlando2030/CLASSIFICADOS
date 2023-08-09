﻿using BUSINESS.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Mappings
{
    public class MarcaMapping : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.NomeMarca)
                .IsRequired()
                .HasColumnType("varchar(200)");

            // 1 : N =>  Marca : Modelo
            builder.HasMany(m => m.Modelo)
                .WithOne(mo => mo.Marca)
                .HasForeignKey(mo => mo.ID_Marca);

            builder.ToTable("Marcas");
        }
    }
}

