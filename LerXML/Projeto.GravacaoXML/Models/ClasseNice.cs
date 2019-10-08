using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    [XmlRoot("classe-nice")]
    public class ClasseNice
    {
        public int ClasseNiceId { get; set; }

        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlElement("especificacao")]
        public string Especificacao { get; set; }
    }
}
