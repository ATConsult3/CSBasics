using System;
using System.Threading.Tasks;
using static System.Console;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using static andestech.learning.cs2022.utils.Utils;
using andestech.learning.cs2022.library;
using System.IO;
using System.Text;
using System.Linq.Expressions;

using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
//using System.Text.Json // DOTNET 5,6,...
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;




namespace andestech.learning.cs2022
{
    internal class SerialTest
    {

        public static void Main()
        {

            Library lib = new Library();
            lib.AddBook(new Book { Author = "А.Толстой", Title = "Аэлита" });
            lib.AddBook(new Book { Author = "J.London", Title = "White silence" });
            echo<Book>(lib.Books);

            echo("Binary serializing");

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("library.bin", FileMode.OpenOrCreate))
            {
               bf.Serialize(fs, lib);
            }
            // deserializing
            Library lib2 = null;
            echo("Restored books from disk");
            using (FileStream fs = new FileStream("library.bin", FileMode.OpenOrCreate))
            {
                lib2 = bf.Deserialize(fs) as Library;
                lib2.echo();
            }

            // ------------  Xml serializing
            echo("Xml serializing");
            XmlSerializer xml = new XmlSerializer(typeof(Library));
            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, lib);
            }
            WriteLine(File.ReadAllText("library.xml"));
            // ------------  Xml DEserializing
            Library lib3 = null;
            using (FileStream fs = new FileStream("library.xml", FileMode.OpenOrCreate))
            {
                lib3 = xml.Deserialize(fs) as Library;
                lib3.echo();
            }

            // ------------  JSON serializing
            echo("JSON serializing");
            JsonSerializer json = new JsonSerializer();
            //json.
            using (TextWriter fs = new StreamWriter(
                new FileStream("library.json",FileMode.OpenOrCreate), Encoding.UTF8))
            {
                json.Serialize(fs, lib);
            }
            WriteLine(File.ReadAllText("library.json"));

        }


    }
}
