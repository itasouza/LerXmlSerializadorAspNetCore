using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class ClassesVienna
    {
        public int ClassesViennaId { get; set; }
        public string Edicao { get; set; }
        public ICollection<ClasseVienna> ClasseVienna { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }

        public static ClassesVienna Adapter(ClassesViennaDTO classesViennaDTO, Processo processo)
        {
            ClassesVienna classesVienna = new ClassesVienna();
            classesVienna.Edicao = classesViennaDTO.Edicao;
            classesVienna.Processo = processo;
            classesVienna.ProcessoId = processo.ProcessoId;
            classesVienna.ClasseVienna = new List<ClasseVienna>();

            if (classesViennaDTO.ClasseVienna != null)
            {
                foreach (var classeVienaDTO in classesViennaDTO.ClasseVienna)
                    classesVienna.ClasseVienna.Add(Models.ClasseVienna.Adapter(classeVienaDTO, classesVienna));
            }
            
            return classesVienna;
        }

    }
}
