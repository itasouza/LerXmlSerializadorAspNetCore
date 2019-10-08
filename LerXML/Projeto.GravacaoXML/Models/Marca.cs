using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    [XmlRoot("marca")]
    public class Marca
    {
        public int MarcaId { get; set; }

        [XmlAttribute("apresentacao")]
        public string Apresentacao { get; set; }

        [XmlAttribute("natureza")]
        public string Natureza { get; set; }

        [XmlElement("nome")]
        public string Nome { get; set; }
    }
}
