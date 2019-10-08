using System;
using System.IO;
using System.Xml.Serialization;

namespace LerXmlRevista
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Revista));
                StreamReader sr = new StreamReader(@"C:\GitHub\LerXmlSerializadorAspNetCore-master\LerXmlSerializadorAspNetCore-master\LerXML\LerXmlExemplo\2323.xml");
                //var revista = xmlSerializer.Deserialize(sr);
                Revista revista1 = (Revista)xmlSerializer.Deserialize(sr);
                Console.WriteLine("Deu");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
