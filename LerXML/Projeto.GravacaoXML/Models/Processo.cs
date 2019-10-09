using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;

namespace Projeto.GravacaoXML.Models
{

    public class Processo
    {
        public int ProcessoId { get; set; }
        public int? Numero { get; set; }
        public DateTime? DataDoDeposito { get; set; }
        public int RevistaId { get; set; }
        public Revista Revista { get; set; }
        public ICollection<Despacho> Despachos { get; set; }
        public ICollection<Titular> Titulares { get; set; }
        public Marca Marca { get; set; }
        public ClassesVienna ClassesVienna { get; set; }
        public ClasseNice ClasseNice { get; set; }
        public string Apostila { get; set; }
        public string Procurador { get; set; }

        public static Processo Adapter(ProcessoDTO processoDTO, Revista revista)
        {
            var processo = new Processo();
            processo.Apostila = processoDTO.Apostila;

            if (!string.IsNullOrEmpty(processoDTO.Numero))
                processo.Numero = Convert.ToInt32(processoDTO.Numero);

            if (!string.IsNullOrEmpty(processoDTO.DataDoDeposito))
                processo.DataDoDeposito = Convert.ToDateTime(processoDTO.DataDoDeposito);

            processo.Procurador = processoDTO.Procurador;
            processo.Revista = revista;
            processo.RevistaId = revista.RevistaId;

            if (processoDTO.Marca != null)
                processo.Marca = Marca.Adapter(processoDTO.Marca, processo);

            if (processoDTO.ClassesVienna != null)
                processo.ClassesVienna = ClassesVienna.Adapter(processoDTO.ClassesVienna, processo);

            if (processoDTO.ClasseNice != null)
                processo.ClasseNice = ClasseNice.Adapter(processoDTO.ClasseNice, processo);

            processo.Despachos = new List<Despacho>();

            if (processoDTO.Despachos != null)
            {
                foreach (var despachoDTO in processoDTO.Despachos)
                    processo.Despachos.Add(Despacho.Adapter(despachoDTO, processo));
            }

            processo.Titulares = new List<Titular>();

            if (processoDTO.Titulares != null)
            {
                foreach (var titularDTO in processoDTO.Titulares)
                    processo.Titulares.Add(Titular.Adapter(titularDTO, processo));
            }

            return processo;
        }

    }
}
