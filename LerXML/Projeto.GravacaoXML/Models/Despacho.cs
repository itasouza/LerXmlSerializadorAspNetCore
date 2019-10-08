using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    [XmlRoot("despacho")]
    public class Despacho
    {
        public int DespachoId { get; set; }

        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlAttribute("nome")]
        public string Nome { get; set; }


        public int ProcessoId { get; set; }
        public Processo Processo {get;set;}
    }
}
