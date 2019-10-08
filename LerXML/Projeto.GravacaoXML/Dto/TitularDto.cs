using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    public class TitularDto
    {
        public int TitularId { get; set; }
        public string RazaoSocial { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
    }
}
