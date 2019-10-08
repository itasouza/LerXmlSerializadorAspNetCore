using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
 
    public class ClasseViennaDto
    {
        public int ClasseViennaId { get; set; }
        public int Codigo { get; set; }
        public int ClassesViennaId { get; set; }
        public ClassesVienna ClassesVienna { get; set; }

    }
}
