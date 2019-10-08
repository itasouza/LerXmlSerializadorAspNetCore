using Microsoft.EntityFrameworkCore;
using Projeto.GravacaoXML.Mapeamento;
using Projeto.GravacaoXML.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.GravacaoXML.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Revista> REVISTA { get; set; }
        public DbSet<Processo> PROCESSO { get; set; }
        public DbSet<ClassesVienna> CLASSESVIENNA { get; set; }
        public DbSet<ClasseVienna> CLASSEVIENNA { get; set; }
        public DbSet<Despacho>  DESPACHO { get; set; }
        public DbSet<Titular> TITULAR { get; set; }
        public DbSet<Marca> MARCA { get; set; }
        public DbSet<ClasseNice>  CLASSENICE { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RevistaMap());
            modelBuilder.ApplyConfiguration(new ProcessoMap());
            modelBuilder.ApplyConfiguration(new ClassesViennaMap());
            modelBuilder.ApplyConfiguration(new ClasseViennaMap());
            modelBuilder.ApplyConfiguration(new DespachoMap());
            modelBuilder.ApplyConfiguration(new TitularMap());
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new ClasseNiceMap());
        }


    }
}
