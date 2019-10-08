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
            builder.Property(x => x.Codigo).HasColumnType("int").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("nText").HasMaxLength(200).IsRequired();


            builder.ToTable("DESPACHO");
        }
    }

}
