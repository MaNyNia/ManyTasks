using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace HW_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();

            DirectoryInfo d = new DirectoryInfo(path);
            d.Create();

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("-------------");

            FileStream stream = File.Open(name, FileMode.OpenOrCreate);
          


            var person = new Person("Pechken", "postman", 53, "Martina", 14, "Fedor");

            /*
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            byte[] array = System.Text.Encoding.Default.GetBytes(text);
            stream.Write(array, 0, array.Length);
            */
          
            
                StreamWriter streamWriter = new StreamWriter(stream);
                JsonSerializer js = new JsonSerializer();
                js.Serialize(streamWriter, js);


            var jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine(jsonString);

            var Obj = JsonConvert.DeserializeObject(jsonString);



            stream.Close();

        }
       
    }
}
    

