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
                Console.WriteLine("Mida soovite teha?\n1.Märget luua. (Loo)\n2.Märget muuta. (Muuda)\n3.Märget kustutada. (Kustuta) \n4.Programmist väljuda. (V2lju)");

                string choice = Console.ReadLine();
                Console.WriteLine("Pealkiri:");

                var title = Console.ReadLine();
 

                //XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
                //doc.AppendChild(element1);
                #region Loo

                if (choice == "Loo")
                {
                    
                    ////System.IO.File.WriteAllText(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\Pealkirjad.txt", title);


                    using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + title + ".xml"))

                    {

                        writer.WriteStartDocument();
                        writer.WriteStartElement(title);
                        writer.WriteStartElement("Pealkiri", title);
                        Console.WriteLine("Sisu:");
                        writer.WriteElementString("Sisu", Console.ReadLine());
               
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
                #endregion

                #region Kustuta

                if (choice == "Kustuta")
                { Console.WriteLine("Millist faili soovite kustutada?");
                    var failinimi = Console.ReadLine();
                    File.Delete(@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + failinimi + ".xml");
                    Console.WriteLine("Aitäh! Fail on kustutatud!");
                }
                #endregion

                if (choice == "Muuda")
                {
                    Console.WriteLine("Millist faili soovite muuta?");
                    var fail = Console.ReadLine();
                    var pathname = (@"C:\Users\Krizzie\Documents\GitHub\class\XML - note\" + fail + ".xml");
                    XElement d = XElement.Load(pathname);

                   
                    int Count = 1;
                    Console.WriteLine("Muuda pealkirja:");
                    var pealkirim = Console.ReadLine();
                    //XmlNode node = doc.SelectSingleNode("Pealkiri/" + fail);


                    Console.WriteLine(Count + ". " + node.Attributes["Pealkiri"].Value);
                    node.Attributes["Pealkiri"].Value = pealkirim;
                    Count += 1;


                    //XmlNode node = doc.SelectSingleNode("Root/Node/Element");
                    //node.Attributes[0].Value = pealkirim;t.Element("level").Element("node1").Value = "";
                    //d.Element(title).Value = pealkirim;
                    //d.Element("level").Element("node3").Value = "";


                    Console.WriteLine("Muuda sisu:");
                    var sisum = Console.ReadLine();
                    XmlNode node2 = doc.SelectSingleNode("Node/" + fail);
                    //node2.Attributes[1].Value = sisum;
                    
                    
                    doc.Save(fail);

                }
                if (choice == "V2lju")
                {
                    break;
                    Environment.Exit(1);
                }
            }
        }

    }
}
    

