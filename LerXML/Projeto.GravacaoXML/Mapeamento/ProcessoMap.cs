using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class ProcessoMap : IEntityTypeConfiguration<Processo>
    {
        public void Configure(EntityTypeBuilder<Processo> builder)
        {
            builder.HasKey(td => td.ProcessoId);
            builder.Property(td => td.Numero).HasColumnType("int");
            builder.Property(td => td.DataDoDeposito).HasColumnType("datetime");

            //1 processo para vários despacho
            builder.HasMany(td => td.Despachos).WithOne(td => td.Processo).HasForeignKey(td => td.ProcessoId);

            //ToTable = nome da tabela

            builder.ToTable("PROCESSO");
        }
    }
}
