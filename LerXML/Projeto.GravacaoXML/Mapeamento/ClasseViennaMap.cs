using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class ClasseViennaMap : IEntityTypeConfiguration<ClasseVienna>
    {
        public void Configure(EntityTypeBuilder<ClasseVienna> builder)
        {
            builder.HasKey(x => x.ClasseViennaId);
            builder.Property(x => x.Codigo).HasColumnType("varchar(20)");

            builder.ToTable("CLASSEVIENNA");
        }
    }
}
