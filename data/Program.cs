using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<>

            //var cars = new List<string>();
            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";
            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var cars = new List<string> {"BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };            
            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 20 },
                new Human(){Name = "Malle", Age = 25 },
                new Human(){Name = "Mari", Age = 30 },
                new Human(){Name = "Elmar", Age = 20 },
                new Human(){Name = "Juku", Age = 20 },
            };

            var query = (from element in humans1
                         orderby element.Age ascending
                         where element.Age > 20
                         select element).ToList();
            foreach (var item in query)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //var human2 = new Human();
            //Console.WriteLine("Sisestage nimi");
            //human2.Name = Console.ReadLine();
            //Console.WriteLine("Sisestage vanus");
            //human2.Age = int.Parse(Console.ReadLine());
            //humans1.Add(human2);

            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
                         #endregion

                         #region Dictionary

            //var openWith = new Dictionary<string, string>();

            ////            key      value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";



            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException ex)
            //{               
            //    Console.WriteLine("An element with key \"txt\" already exists");
            //}

            //Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            //Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);

            //try
            //{
            //    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            //string value = "";
            //if(openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}.", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key = \"tif\" is not found");
            //}

            ////Vaatame kas "ht" võti on olemas, kui ei ole lisame
            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            //}

            ////Küsime võtmed ja väärtused kasutades foreach tsüklit
            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            ////Küsime väärtused
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            ////Küsime võtmed
            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;
            //foreach (var item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            ////Kustutame võtme/väärtuse 
            //openWith.Remove("doc");
            //if(!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found.");
            //}

                         #endregion

                         #region Queue - First in first out (FIFO)

            //////Loome Queue(Järjekorra) 
            //Console.WriteLine("QUEUE:");
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            ////Küsime elemendid järjekorrast
            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine();
            ////Võtame välja esimese elemendi
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            ////Piilume järgmist elementi
            //Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            ////Võtame välja järgmise
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            ////Teeme koopia järjekorrast
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\n Contents of the first Copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);
            //Console.WriteLine("array items");
            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\nContents of the second Copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy contains 'four' = {0}", queueCopy.Contains("four"));
            ////tühjendame järjekorra
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is: {0} ",queueCopy.Count);

                         #endregion

                         #region Stack - Last in first out

            //Console.WriteLine("Stack");
            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'",numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

                         #endregion

                         #region LINQ

            //Andmekogum
            int[] numbers = new int[7] {0, 1, 2, 3, 4 , 5, 6 };

            //Loome päringu
            //var evenNumQuery = from num in numbers
            //               where (num % 2) == 0
            //               select num;
            //int evenNumCount = evenNumQuery.Count();

            var evenNumQuery = (from num in numbers
                               where (num % 2) == 0
                               select num).ToList();
            

            #endregion

            Console.ReadLine();
        }
    }
}
