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
            builder.Property(td => td.ClasseViennaId).HasColumnType("char(32)").IsRequired();
            builder.Property(x => x.Codigo).HasColumnType("varchar(8000)").IsRequired(false);

            builder.Property(x => x.ClassesViennaId).HasColumnType("char(32)").IsRequired();
            builder.HasOne(x => x.ClassesVienna).WithMany(x => x.ClasseVienna).HasForeignKey(x => x.ClasseViennaId).OnDelete(DeleteBehavior.Restrict);
           
            builder.ToTable("CLASSEVIENNA");
        }
    }
}
