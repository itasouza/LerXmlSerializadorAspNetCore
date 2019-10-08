using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    [XmlRoot("classes-vienna")]
    public class ClassesVienna
    {
        public int ClassesViennaId { get; set; }

        [XmlAttribute("edicao")]
        public string Edicao { get; set; }

        [XmlElement("classe-vienna")]
        public ClasseVienna[] ClasseVienna { get; set; }

        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }

    }
}
