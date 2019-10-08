using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    [XmlRoot("titular")]
    public class Titular
    {
        public int TitularId { get; set; }

        [XmlAttribute("nome-razao-social")]
        public string RazaoSocial { get; set; }

        [XmlAttribute("pais")]
        public string Pais { get; set; }

        [XmlAttribute("uf")]
        public string UF { get; set; }
    }
}
