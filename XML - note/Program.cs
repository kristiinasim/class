using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML___note
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            Console.WriteLine("Mida soovite teha?\n1.Märget luua.\n2.Märget lugeda.\n3.Märget kustutada");
            string choice = Console.ReadLine();
            var chc = new List<Note>();
            XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
            doc.AppendChild(element1);
        }
    }
}
