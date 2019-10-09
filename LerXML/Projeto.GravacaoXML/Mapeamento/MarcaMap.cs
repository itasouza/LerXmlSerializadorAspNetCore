using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(x => x.MarcaId);
            builder.Property(td => td.MarcaId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Natureza).HasColumnType("varchar(200)");
            builder.Property(x => x.Nome).HasColumnType("varchar(200)");
            builder.Property(x => x.Apresentacao).HasColumnType("varchar(200)");
            builder.Property(x => x.ProcessoId).HasColumnType("int").IsRequired();

            builder.ToTable("MARCA");
        }
    }
}
