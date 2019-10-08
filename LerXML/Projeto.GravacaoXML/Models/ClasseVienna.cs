using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    [XmlRoot("classe-vienna")]
    public class ClasseVienna
    {
        public int ClasseViennaId { get; set; }

        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        public int ClassesViennaId { get; set; }
        public ClassesVienna ClassesVienna { get; set; }

    }
}
