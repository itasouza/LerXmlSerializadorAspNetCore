using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
 
    public class ClasseVienna
    {
        public int ClasseViennaId { get; set; }
        public string Codigo { get; set; }
        public int ClassesViennaId { get; set; }
        public ClassesVienna ClassesVienna { get; set; }

        public static ClasseVienna Adapter(ClasseViennaDTO classesViennaDTO, ClassesVienna classesVienna)
        {
            ClasseVienna classeVienna = new ClasseVienna();
            classeVienna.Codigo = classesViennaDTO.Codigo;
            classeVienna.ClassesViennaId = classesVienna.ClassesViennaId;
            classeVienna.ClassesVienna = classesVienna;
            
            return classeVienna;
        }

    }
}
