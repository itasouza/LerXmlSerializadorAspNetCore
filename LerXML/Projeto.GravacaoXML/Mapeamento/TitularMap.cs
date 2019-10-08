using Microsoft.EntityFrameworkCore;
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
            builder.Property(x => x.RazaoSocial).HasColumnType("nText").HasMaxLength(200);
            builder.Property(x => x.Pais).HasColumnType("nText").HasMaxLength(100);
            builder.Property(x => x.UF).HasColumnType("nText").HasMaxLength(2);

            builder.ToTable("TITULAR");
        }
    }
}
