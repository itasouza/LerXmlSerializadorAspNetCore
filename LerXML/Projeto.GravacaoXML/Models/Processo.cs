using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    [XmlRoot("processo")]
    public class Processo
    {
        public int ProcessoId { get; set; }

        [XmlAttribute("numero")]
        public int Numero { get; set; }

        [XmlAttribute("data-deposito")]
        public DateTime DataDoDeposito { get; set; }

        public int RevistaId { get; set; }
        public Revista Revista { get; set; }

        [XmlArray("despachos")]
        [XmlArrayItem("despacho", typeof(Despacho))]
        public Despacho[] Despachos { get; set; }

        [XmlArray("titulares")]
        [XmlArrayItem("titular", typeof(Titular))]
        public Titular[] Titulares { get; set; }

        [XmlElement("marca")]
        public Marca Marca { get; set; }

        [XmlElement("classes-vienna")]
        public ClassesVienna ClassesVienna { get; set; }

        [XmlElement("classe-nice")]
        public ClasseNice ClasseNice { get; set; }

        [XmlElement("apostila")]
        public string Apostila { get; set; }

        [XmlElement("procurador")]
        public string Procurador { get; set; }
    }
}
