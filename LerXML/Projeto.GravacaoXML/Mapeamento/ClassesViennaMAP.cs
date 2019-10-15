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
            builder.Property(td => td.ClassesViennaId).HasColumnType("char(32)").IsRequired();
            builder.Property(x => x.Edicao).HasColumnType("varchar(8000)");
            builder.Property(x => x.ProcessoId).HasColumnType("char(32)").IsRequired();
            builder.HasOne(x => x.Processo).WithOne(x => x.ClassesVienna);

            builder.HasMany(x => x.ClasseVienna)
                .WithOne()
                .HasForeignKey(x => x.ClasseViennaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("CLASSESVIENNA");
        }
    }
}
