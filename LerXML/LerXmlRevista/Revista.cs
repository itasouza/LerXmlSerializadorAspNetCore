using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LerXmlRevista
{

    [XmlRoot("revista")]
    public class Revista
    {
        [XmlAttribute("numero")]
        public string Numero { get; set; }

        [XmlAttribute("data")]
        public string Data { get; set; }

        [XmlElement("processo")]
        public Processo[] Processos { get; set; }

    }

    [XmlRoot("processo")]
    public class Processo
    {
        [XmlAttribute("numero")]
        public string Numero { get; set; }
        
        [XmlAttribute("data-deposito")]
        public string DataDoDeposito { get; set; }

        [XmlArray("despachos")]
        [XmlArrayItem("despacho", typeof(Despacho))]
        public Despacho[] Despachos { get; set; }

        [XmlArray("titulares")]
        [XmlArrayItem("titular", typeof(Titular))]
        public Titular[] Titulares { get; set; }

        [XmlElement("marca")]
        public Marca Marca { get; set; }

        [XmlElement("classes-vienna")]
        public ClassesVienna ClassesVienna { get; set; }

        [XmlElement("classe-nice")]
        public ClasseNice ClasseNice { get; set; }

        [XmlElement("apostila")]
        public string Apostila { get; set; }

        [XmlElement("procurador")]
        public string Procurador { get; set; }
    }


    [XmlRoot("classes-vienna")]
    public class ClassesVienna
    {
        [XmlAttribute("edicao")]
        public string Edicao { get; set; }

        [XmlElement("classe-vienna")]
        public ClasseVienna[] ClasseVienna { get; set; }

    }

    [XmlRoot("classe-vienna")]
    public class ClasseVienna
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

    }

    [XmlRoot("despacho")]
    public class Despacho
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlAttribute("nome")]
        public string Nome { get; set; }
    }

    [XmlRoot("titular")]
    public class Titular
    {
        [XmlAttribute("nome-razao-social")]
        public string RazaoSocial { get; set; }

        [XmlAttribute("pais")]
        public string Pais { get; set; }

        [XmlAttribute("uf")]
        public string UF { get; set; }
    }

    [XmlRoot("marca")]
    public class Marca
    {
        [XmlAttribute("apresentacao")]
        public string Apresentacao { get; set; }

        [XmlAttribute("natureza")]
        public string Natureza { get; set; }

        [XmlElement("nome")]
        public string Nome { get; set; }
    }

    [XmlRoot("classe-nice")]
    public class ClasseNice
    {
        [XmlAttribute("codigo")]
        public string Codigo { get; set; }

        [XmlElement("especificacao")]
        public string Especificacao { get; set; }
    }
}
//https://www.youtube.com/watch?v=UvEF7UPh1Qg