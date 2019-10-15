using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    public class Titular
    {
        public string TitularId { get; set; }
        public string RazaoSocial { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string ProcessoId { get; set; }
        public Processo Processo { get; set; }

        public static Titular Adapter(TitularDTO titularDTO, Processo processo)
        {
            var titular = new Titular();

            titular.TitularId  = Guid.NewGuid().ToString().Replace("-", "");
            titular.RazaoSocial = titularDTO.RazaoSocial;
            titular.Pais = titularDTO.Pais;
            titular.UF = titularDTO.UF;
            titular.Processo = processo;
            titular.ProcessoId = processo.ProcessoId;

            return titular;
        }
    }
}
