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


                //XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
                //doc.AppendChild(element1);
                #region Loo

                if (choice == "Loo")
                {
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
                    doc.Load(pathname);
                    doc.SelectSingleNode("/appSettings/add").Attributes["Pealkiri"].Value = Console.ReadLine();
                    doc.SelectSingleNode("/appSettings/add").Attributes["Sisu"].Value = Console.ReadLine();
                    doc.Save(fail);

                }
                //if (choice == "V2lju")
                //{
                //    break;
                //    Environment.ExitCode();
                //}
            }
        }

    }
}
    

