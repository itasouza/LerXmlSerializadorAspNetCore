using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class ClasseNice
    {
        public int ClasseNiceId { get; set; }
        public int? Codigo { get; set; }
        public string Especificacao { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }

        public static ClasseNice Adapter(ClasseNiceDTO classeNiceDTO, Processo processo)
        {
            var classeNice = new ClasseNice();
            
            if (!string.IsNullOrEmpty(classeNiceDTO.Codigo))
                classeNice.Codigo = Convert.ToInt32(classeNiceDTO.Codigo);

            classeNice.Especificacao = classeNiceDTO.Especificacao;
            classeNice.Processo = processo;
            classeNice.ProcessoId = processo.ProcessoId;

            return classeNice;
        }

    }
}
