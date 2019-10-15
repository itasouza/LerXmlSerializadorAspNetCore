﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto.GravacaoXML.Data;

namespace Projeto.GravacaoXML.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191015125418_CreateSchema")]
    partial class CreateSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClasseNice", b =>
                {
                    b.Property<string>("ClasseNiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<int?>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Especificacao")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ProcessoId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.HasKey("ClasseNiceId");

                    b.HasIndex("ProcessoId")
                        .IsUnique();

                    b.ToTable("CLASSENICE");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClasseVienna", b =>
                {
                    b.Property<string>("ClasseViennaId")
                        .HasColumnType("char(32)");

                    b.Property<string>("ClassesViennaId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(8000)");

                    b.HasKey("ClasseViennaId");

                    b.ToTable("CLASSEVIENNA");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClassesVienna", b =>
                {
                    b.Property<string>("ClassesViennaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<string>("Edicao")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("ProcessoId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.HasKey("ClassesViennaId");

                    b.HasIndex("ProcessoId")
                        .IsUnique();

                    b.ToTable("CLASSESVIENNA");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Despacho", b =>
                {
                    b.Property<string>("DespachoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("ProcessoId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.HasKey("DespachoId");

                    b.HasIndex("ProcessoId");

                    b.ToTable("DESPACHO");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Marca", b =>
                {
                    b.Property<string>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<string>("Apresentacao")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Natureza")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("ProcessoId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.HasKey("MarcaId");

                    b.HasIndex("ProcessoId")
                        .IsUnique();

                    b.ToTable("MARCA");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Processo", b =>
                {
                    b.Property<string>("ProcessoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<string>("Apostila")
                        .HasColumnType("varchar(8000)");

                    b.Property<DateTime?>("DataDoDeposito")
                        .HasColumnType("DateTime");

                    b.Property<int?>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Procurador")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("RevistaId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.HasKey("ProcessoId");

                    b.HasIndex("RevistaId");

                    b.ToTable("PROCESSO");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Revista", b =>
                {
                    b.Property<string>("RevistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("DateTime");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("RevistaId");

                    b.ToTable("REVISTA");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Titular", b =>
                {
                    b.Property<string>("TitularId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(32)");

                    b.Property<string>("Pais")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProcessoId")
                        .IsRequired()
                        .HasColumnType("char(32)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("UF")
                        .HasColumnType("varchar(2)");

                    b.HasKey("TitularId");

                    b.HasIndex("ProcessoId");

                    b.ToTable("TITULAR");
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClasseNice", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Processo", "Processo")
                        .WithOne("ClasseNice")
                        .HasForeignKey("Projeto.GravacaoXML.Models.ClasseNice", "ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClasseVienna", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.ClassesVienna", "ClassesVienna")
                        .WithMany("ClasseVienna")
                        .HasForeignKey("ClasseViennaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.ClassesVienna", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Processo", "Processo")
                        .WithOne("ClassesVienna")
                        .HasForeignKey("Projeto.GravacaoXML.Models.ClassesVienna", "ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Despacho", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Processo", "Processo")
                        .WithMany("Despachos")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Marca", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Processo", "Processo")
                        .WithOne("Marca")
                        .HasForeignKey("Projeto.GravacaoXML.Models.Marca", "ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Processo", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Revista", "Revista")
                        .WithMany("Processos")
                        .HasForeignKey("RevistaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Projeto.GravacaoXML.Models.Titular", b =>
                {
                    b.HasOne("Projeto.GravacaoXML.Models.Processo", "Processo")
                        .WithMany("Titulares")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}