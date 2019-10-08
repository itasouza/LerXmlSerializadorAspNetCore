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
            builder.Property(td => td.Numero).HasColumnType("int").IsRequired(false);
            builder.Property(td => td.DataDoDeposito).HasColumnType("DateTime").IsRequired(false); 
            builder.Property(td => td.Apostila).HasColumnType("varchar(200)"); 
            builder.Property(td => td.Procurador).HasColumnType("varchar(200)"); 

            //1 processo para vários despacho
            builder.HasMany(td => td.Despachos).WithOne(td => td.Processo).HasForeignKey(td => td.ProcessoId);

            //1 processo para vários titulares
            builder.HasMany(td => td.Titulares).WithOne(td => td.Processo).HasForeignKey(td => td.ProcessoId);

            //1 processo para uma marca
            builder.HasOne(td => td.Marca).WithOne(td => td.Processo);

            //1 processo para uma ClassesVienna
            builder.HasOne(td => td.ClassesVienna).WithOne(td => td.Processo);

            //1 processo para uma ClasseNice
            builder.HasOne(td => td.ClasseNice).WithOne(td => td.Processo);

            //ToTable = nome da tabela

            builder.ToTable("PROCESSO");
        }
    }
}
