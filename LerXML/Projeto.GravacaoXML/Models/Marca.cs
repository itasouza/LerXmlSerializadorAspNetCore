using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{

    public class Marca
    {
        public string MarcaId { get; set; }
        public string Apresentacao { get; set; }
        public string Natureza { get; set; }
        public string Nome { get; set; }
        public string ProcessoId { get; set; }
        public Processo Processo { get; set; }

        public static Marca Adapter(MarcaDTO marcaDTO, Processo processo)
        {
            Marca marca = new Marca();

            marca.MarcaId = Guid.NewGuid().ToString().Replace("-", "");
            marca.Apresentacao = marcaDTO.Apresentacao;
            marca.Natureza = marcaDTO.Natureza;
            marca.Nome = marcaDTO.Nome;
            marca.Processo = processo;
            marca.ProcessoId = processo.ProcessoId;

            return marca;
        }
    }
}
