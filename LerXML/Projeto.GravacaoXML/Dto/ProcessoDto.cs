using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class ProcessoDto
    {
        public int ProcessoId { get; set; }
        public int Numero { get; set; }
        public DateTime DataDoDeposito { get; set; }
        public int RevistaId { get; set; }
        public Revista Revista { get; set; }
        public Despacho[] Despachos { get; set; }
        public Titular[] Titulares { get; set; }
        public Marca Marca { get; set; }
        public ClassesVienna ClassesVienna { get; set; }
        public ClasseNice ClasseNice { get; set; }
        public string Apostila { get; set; }
        public string Procurador { get; set; }
    }
}
