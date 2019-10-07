using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace LerXmlExemplo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }


        public bool Exportar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Create);
                XmlSerializer serializador = new XmlSerializer(typeof(Cliente));
                serializador.Serialize(stream, this);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Cliente Importar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(Cliente));
                Cliente cliente = (Cliente)desserializador.Deserialize(stream);
                return cliente;
            }
            catch
            {
                return null;
            }
        }
    }
}
