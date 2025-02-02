﻿using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class Despacho
    {
        public string DespachoId { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string ProcessoId { get; set; }
        public Processo Processo {get;set;}

        public static Despacho Adapter(DespachoDTO despachoDTO, Processo processo)
        {
            var despacho = new Despacho();
            despacho.DespachoId = Guid.NewGuid().ToString().Replace("-", "");
            despacho.Codigo = despachoDTO.Codigo;
            despacho.Nome = despachoDTO.Nome;
            despacho.Processo = processo;
            despacho.ProcessoId = processo.ProcessoId;

            return despacho;
        }
    }
}
