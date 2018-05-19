using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
namespace XML___note
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mida soovite teha?\n1.Märget luua. (Loo)\n2.Märget lugeda. (Loe)\n3.Märget kustutada (Kustuta)");
            string choice = Console.ReadLine();

            //XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
            //doc.AppendChild(element1);
            if (choice == "Loo")
            {
                using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\Notes.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Notes");
                    Console.WriteLine("Pealkiri:");
                    writer.WriteStartElement("Pealkiri", Console.ReadLine());
                    Console.WriteLine("Sisu:");
                    writer.WriteElementString("Sisu", Console.ReadLine());
                    writer.WriteEndElement();
                    doc.Save(writer);
                    Console.WriteLine("Aitäh! Fail salvestatud!");
                }
                if (choice == "Loe")
                {


                    if (choice == "Kustuta")
                    {
                        Console.WriteLine("Millist faili soovite kustutada?");
                        var failinimi = Console.ReadLine();
                        File.Delete(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\"failinimi".xml");
                  

                    }
                }

            }
        }
    }
}

