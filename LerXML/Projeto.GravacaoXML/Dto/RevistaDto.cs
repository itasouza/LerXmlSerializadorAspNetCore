using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    public class RevistaDto
    {
        public int RevistaId { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public Processo[] Processos { get; set; }

    }  

}