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
            builder.Property(td => td.ClasseViennaId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Codigo).HasColumnType("varchar(200)").IsRequired(false);

            builder.Property(x => x.ClassesViennaId).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.ClassesVienna).WithMany(x => x.ClasseVienna).HasForeignKey(x => x.ClasseViennaId).OnDelete(DeleteBehavior.Restrict);
           
            builder.ToTable("CLASSEVIENNA");
        }
    }
}
