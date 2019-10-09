using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{

    public class DespachoMap : IEntityTypeConfiguration<Despacho>
    {
        public void Configure(EntityTypeBuilder<Despacho> builder)
        {
            
            builder.HasKey(x => x.DespachoId);
            builder.Property(td => td.DespachoId).HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Codigo).HasColumnType("varchar(200)").IsRequired(false);
            builder.Property(x => x.Nome).HasColumnType("varchar(200)");
            builder.Property(x => x.ProcessoId).HasColumnType("int").IsRequired();


            builder.ToTable("DESPACHO");
        }
    }

}
