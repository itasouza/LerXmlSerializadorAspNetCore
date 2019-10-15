using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class ClasseNiceMap : IEntityTypeConfiguration<ClasseNice>
    {
        public void Configure(EntityTypeBuilder<ClasseNice> builder)
        {
            builder.HasKey(x => x.ClasseNiceId);
            builder.Property(td => td.ClasseNiceId).HasColumnType("char(32)").IsRequired();
            builder.Property(x => x.Codigo).HasColumnType("int").IsRequired(false); 
            builder.Property(x => x.Especificacao).HasColumnType("varchar(max)");
            builder.Property(x => x.ProcessoId).HasColumnType("char(32)").IsRequired();

            builder.ToTable("CLASSENICE");
        }
    }
}
