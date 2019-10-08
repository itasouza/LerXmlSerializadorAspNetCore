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
            builder.Property(x => x.Codigo).HasColumnType("varchar(20)"); 
            builder.Property(x => x.Especificacao).HasColumnType("varchar(300)");

            builder.ToTable("CLASSENICE");
        }
    }
}
