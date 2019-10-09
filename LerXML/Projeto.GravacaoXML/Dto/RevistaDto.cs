using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Projeto.GravacaoXML.Dto
{

    [XmlRoot("revista")]
    public class RevistaDTO
    {
        [XmlAttribute("numero")]
        public string Numero { get; set; }

        [XmlAttribute("data")]
        public string Data { get; set; }

        [XmlElement("processo")]
        public ProcessoDTO[] Processos { get; set; }

    }

    [XmlRoot("processo")]
    public class ProcessoDTO
    {
        [XmlAttribute("numero")]
        public string Numero { get; set; }
        
        [XmlAttribute("data-deposito")]
        public string DataDoDeposito { get; set; }

        [XmlArray("despachos")]
        [XmlArrayItem("despacho", typeof(DespachoDTO))]
        public DespachoDTO[] Despachos { get; set; }

        [XmlArray("titulares")]
        [XmlArrayItem("titular", typeof(TitularDTO))]
        public TitularDTO[] Titulares { get; set; }

        [XmlElement("marca")]
        public MarcaDTO Marca { get; set; }

        [XmlElement("classes-vienna")]
        public ClassesViennaDTO ClassesVienna { get; set; }

        [XmlElement("classe-nice")]
        public ClasseNiceDTO ClasseNice { get; set; }

        [XmlElement("apostila")]
        public string Apostila { get; set; }

        [XmlElement("procurador")]
        public string Procurador { get; set; }
    }


    [XmlRoot("classes-vienna")]
    public class ClassesViennaDTO
    {
        [XmlAttribute("edicao")]
        public string Edicao { get; set; }

        [XmlElement("classe-vienna")]
        public ClasseViennaDTO[] ClasseVienna { get; set; }

    }

    [XmlRoot("classe-vienna")]
    public class ClasseViennaDTO
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

    }

    [XmlRoot("despacho")]
    public class DespachoDTO
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlAttribute("nome")]
        public string Nome { get; set; }
    }

    [XmlRoot("titular")]
    public class TitularDTO
    {
        [XmlAttribute("nome-razao-social")]
        public string RazaoSocial { get; set; }

        [XmlAttribute("pais")]
        public string Pais { get; set; }

        [XmlAttribute("uf")]
        public string UF { get; set; }
    }

    [XmlRoot("marca")]
    public class MarcaDTO
    {
        [XmlAttribute("apresentacao")]
        public string Apresentacao { get; set; }

        [XmlAttribute("natureza")]
        public string Natureza { get; set; }

        [XmlElement("nome")]
        public string Nome { get; set; }
    }

    [XmlRoot("classe-nice")]
    public class ClasseNiceDTO
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlElement("especificacao")]
        public string Especificacao { get; set; }
    }
}
//https://www.youtube.com/watch?v=UvEF7UPh1Qg