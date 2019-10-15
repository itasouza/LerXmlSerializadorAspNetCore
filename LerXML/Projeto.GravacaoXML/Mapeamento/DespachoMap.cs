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
            builder.Property(td => td.DespachoId).HasColumnType("char(32)").IsRequired();
            builder.Property(x => x.Codigo).HasColumnType("varchar(8000)").IsRequired(false);
            builder.Property(x => x.Nome).HasColumnType("varchar(8000)");
            builder.Property(x => x.ProcessoId).HasColumnType("char(32)").IsRequired();


            builder.ToTable("DESPACHO");
        }
    }

}
