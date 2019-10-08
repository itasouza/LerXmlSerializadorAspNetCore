using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class DespachoDto
    {
        public int DespachoId { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo {get;set;}
    }
}
