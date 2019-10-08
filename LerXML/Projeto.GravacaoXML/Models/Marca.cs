using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class Marca
    {
        public int MarcaId { get; set; }
        public string Apresentacao { get; set; }
        public string Natureza { get; set; }
        public string Nome { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
    }
}
