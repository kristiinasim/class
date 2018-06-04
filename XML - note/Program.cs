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
        /// <summary>
        /// Creates a while cicle first. Program asks user what they want to do. Each if cicle contains a corresponding void for the names choice.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)

            {

            Console.WriteLine("Mida soovite teha?\n1.Märget luua. (Loo)\n2.Märget muuta. (Muuda)\n3.Märget kustutada. (Kustuta) \n4.Programmist väljuda. (V2lju)");
            string choice = Console.ReadLine();
            if (choice == "Loo")
            {
                Loo();
            }
            if (choice == "Kustuta")
            {
                Delete();
            }
            if (choice == "Muuda")
            {
                Change();
            }
            if (choice == "V2lju")
            {
                Exit();
            }
            else

            {
                Console.WriteLine("Tegite midagi valesti! Proovige palun uuesti!");
            }

           }

        }

        /// <summary>
        /// Creates an XML file, user can type a title and content.
        /// </summary>
        static void Loo()
        {
            XmlDocument doc = new XmlDocument();
            Console.WriteLine("Pealkiri:");
            var title = Console.ReadLine();
            using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + title + ".xml"))
            {

                writer.WriteStartDocument();
                writer.WriteStartElement(title);
                writer.WriteStartElement("Pealkiri", title);
                Console.WriteLine("Sisu:");
                writer.WriteElementString("Sisu", Console.ReadLine());

                writer.WriteEndElement();
                doc.Save(writer);
                Console.WriteLine("Aitäh! Fail salvestatud!");
                var valik = Console.ReadLine();

            }
        }
        /// <summary>
        /// This void is for deleting files named by user.
        /// </summary>
        static void Delete()
        {
            
            Console.WriteLine("Millist faili soovite kustutada?");
            var failinimi = Console.ReadLine();
            File.Delete(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + failinimi + ".xml");
            Console.WriteLine("Aitäh! Fail on kustutatud!");
        }

        /// <summary>
        /// This void is for changing file's title and content if requested by user.
        /// </summary>

        static void Change()
        {
            XmlDocument doc = new XmlDocument();
            Console.WriteLine("Millist faili soovite muuta?");
            var fail = Console.ReadLine();
            var pathname = (@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + fail + ".xml");
            doc.Load(pathname);

            Console.WriteLine("Muuda pealkirja:");
            var pealkirim = Console.ReadLine();
            XmlNode root = doc.DocumentElement;
            XmlNode myNode = root.SelectSingleNode("Pealkiri");
            if (myNode != null)
            {
                myNode.Value = pealkirim;
                doc.Save(pathname);
            }
            //XmlNode node = doc.SelectSingleNode("Root/Node/Element");
            //node.Attributes[0].Value = pealkirim;t.Element("level").Element("node1").Value = "";
            //d.Element(title).Value = pealkirim;
            //d.Element("level").Element("node3").Value = "";
            Console.WriteLine("Muuda sisu:");
            var sisum = Console.ReadLine();
            XmlNode rootx = doc.DocumentElement;
            XmlNode myNodex = root.SelectSingleNode("Sisu");

            if (myNodex != null)
            {
                myNodex.Value = sisum;
                doc.Save(pathname);
            }
            doc.Save(pathname);

        }
        /// <summary>
        /// This void simply closes the application.
        /// </summary>
        static void Exit()
        {

            Environment.Exit(1);
        }
    }
}

    
    

