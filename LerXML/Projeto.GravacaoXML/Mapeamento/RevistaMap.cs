using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Mapeamento
{
    public class RevistaMap : IEntityTypeConfiguration<Revista>
    {

        public void Configure(EntityTypeBuilder<Revista> builder)
        {
            builder.HasKey(td => td.RevistaId);
            builder.Property(td => td.Numero).HasColumnType("int");
            builder.Property(td => td.Data).HasColumnType("datetime");

            //1 revista para vários processos
            builder.HasMany(td => td.Processos).WithOne(td => td.Revista).HasForeignKey(td => td.RevistaId);

            //ToTable = nome da tabela
            builder.ToTable("REVISTA");
        }
    }
}
