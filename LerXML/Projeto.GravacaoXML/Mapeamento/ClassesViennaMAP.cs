using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class ClassesViennaMap : IEntityTypeConfiguration<ClassesVienna>
    {
        public void Configure(EntityTypeBuilder<ClassesVienna> builder)
        {
            builder.HasKey(x => x.ClassesViennaId);
            builder.Property(x => x.Edicao).HasColumnType("varchar(200)");

            builder.ToTable("CLASSESVIENNA");
        }
    }
}
