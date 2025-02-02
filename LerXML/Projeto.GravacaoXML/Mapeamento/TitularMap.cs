﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class TitularMap : IEntityTypeConfiguration<Titular>
    {
        public void Configure(EntityTypeBuilder<Titular> builder)
        {
            builder.HasKey(x => x.TitularId);
            builder.Property(td => td.TitularId).HasColumnType("char(32)").IsRequired();
            builder.Property(x => x.RazaoSocial).HasColumnType("varchar(8000)");
            builder.Property(x => x.Pais).HasColumnType("varchar(100)");
            builder.Property(x => x.UF).HasColumnType("varchar(2)");
            builder.Property(x => x.ProcessoId).HasColumnType("char(32)").IsRequired();

            builder.ToTable("TITULAR");
        }
    }
}
