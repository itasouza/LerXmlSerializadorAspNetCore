using Projeto.GravacaoXML.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Models
{
    public class Revista
    {
        public Revista()
        {
        }

        public Revista(int numero, DateTime? data, ICollection<Processo> processos)
        {
            RevistaId = Guid.NewGuid().ToString().Replace("-", "");
            Numero = numero;
            Data = data;

            foreach (var processo in processos)
                AdicionarProcesso(processo);
        }
        public string RevistaId { get; set; }
        public int Numero { get; set; }
        public DateTime? Data { get; set; }
        public ICollection<Processo> Processos { get; set; }

        public void AdicionarProcesso(Processo processo)
        {
            if (Processos != null)
                Processos = new List<Processo>();

            processo.RevistaId = RevistaId;
            processo.Revista = this;
            Processos.Add(processo);
        }

        public static Revista Adapter(RevistaDTO revistaDTO)
        {
            var revista = new Revista();
            revista.RevistaId = Guid.NewGuid().ToString().Replace("-", "");
            revista.Numero = Convert.ToInt32(revistaDTO.Numero);

            if (!string.IsNullOrEmpty(revistaDTO.Data))
                revista.Data = Convert.ToDateTime(revistaDTO.Data);

            revista.Processos = new List<Processo>();

            if (revistaDTO.Processos != null)
            {
                foreach (var processoDTO in revistaDTO.Processos)
                {
                    revista.Processos.Add(Processo.Adapter(processoDTO, revista));
                }
            }



            return revista;
        }

    }

}