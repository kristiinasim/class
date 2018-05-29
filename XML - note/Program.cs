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
            XmlDocument doc = new XmlDocument();
            while (true)

            {
                Console.WriteLine("Mida soovite teha?\n1.Märget luua. (Loo)\n2.Märget muuta. (Muuda)\n3.Märget kustutada. (Kustuta)");
             
                string choice = Console.ReadLine();
               

                //XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
                //doc.AppendChild(element1);

                if (choice == "Loo")

                    Console.WriteLine("Pealkiri:");

                var title = Console.ReadLine();

            using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + title + ".xml"))

            {

                writer.WriteStartDocument();
                writer.WriteStartElement(title);
                writer.WriteStartElement("Pealkiri", title);
                //if (doc.DocumentElement.Attributes["Pealkiri"] != null)
                //    Console.WriteLine(doc.DocumentElement.Attributes["Pealkiri"].Value);
                Console.WriteLine("Sisu:");
                writer.WriteElementString("Sisu", Console.ReadLine());

                //if (doc.DocumentElement.Attributes["Sisu"] != null)
                //    Console.WriteLine(doc.DocumentElement.Attributes["Sisu"].Value);

                writer.WriteEndElement();
                doc.Save(writer);
                Console.WriteLine("Aitäh! Fail salvestatud! Kas soovite veel midagi teha? y/n");
                var valik = Console.ReadLine();
                if (valik == "y")
                {
                    continue;
                }
                else if (valik == "n")
                {
                    break;
                }
            }
                }



            //   else 
            //   {
            //        Console.WriteLine("Midagi on valesti! Proovige uuesti!");


            //    }
            //}

            //if (choice == "Loe")
            //{
            //    Console.WriteLine("Millist faili lugeda soovite? Palun sisestage pealkiri!");
            //    var title2 = Console.ReadLine();
            //    string path = (@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + title2 + ".xml");
            //    doc.Load(path);

            //}
            var choice2 = Console.ReadLine();
            if (choice2 == "Kustuta")
            {
                if (doc.DocumentElement.Attributes["Pealkiri"] != null)
                    Console.WriteLine(doc.DocumentElement.Attributes["Pealkiri"].Value);
                Console.WriteLine("Millist faili soovite kustutada?");
                var failinimi = Console.ReadLine();
                File.Delete(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\"+failinimi+".xml");
                if (doc.DocumentElement.Attributes["Sisu"] != null)
                    Console.WriteLine(doc.DocumentElement.Attributes["Sisu"].Value);


            }
        }

    }
}
    

