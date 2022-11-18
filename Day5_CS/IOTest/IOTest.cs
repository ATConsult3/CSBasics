using System.Threading.Tasks;
using static System.Console;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using static andestech.learning.cs2022.utils.Utils;
using andestech.learning.cs2022.library;
using System.IO;
using System.Text;
using System;
using System.Linq.Expressions;

namespace andestech.learning.cs2022
{
    internal class IOTest
    {
        static void Main(string[] args)
        {
            // File, FileInfo
            
            echo("File test");
            File.WriteAllText("file1.txt", "Text1..\nText2..\nМои данные\n", Encoding.UTF8);
            string[] lines = File.ReadAllLines("file1.txt");
            foreach (string line in lines) WriteLine(line);

            FileInfo file1 = new FileInfo("file1.txt");
            file1.CopyTo($"data_{DateTime.Now:yyyy_MM_dd_hh_mm_ss_fff}.log");
            //file1.


            // Directory, DirectoryInfo
            Directory.CreateDirectory("dir2");
            Directory.CreateDirectory("dir3\\dir4");

            DirectoryInfo dir = new DirectoryInfo("dir1");
            WriteLine(dir.Exists);

            // ------------- Вариант 1 ------------
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream("greets", FileMode.OpenOrCreate);
                    //...
                    //...

                }
                catch (IOException ex)
                {
                    //log ex
                    throw ex;
                }
                finally
                {
                    fs?.Close();
                }
            }

            // ------------ Вариант 2 ------------
            try
            {
                using (FileStream fs = new FileStream("greets", FileMode.OpenOrCreate))
                {

                }
            }
            catch (IOException ex)
            {
                // log ex
                throw ex;
            }


            // ------------ Вариант 3 ----------
            using (FileStream fs = new FileStream("greets", FileMode.OpenOrCreate))
            {
                string greets = "Hi!!\nПривет!\nSalute!\nHello!";
                byte[] barr = Encoding.UTF8.GetBytes(greets);
                fs.Write(barr,0, barr.Length);
            }
            // Reader
            echo("FileStream reader from greets");
            using (FileStream fs = new FileStream("greets", FileMode.Open, FileAccess.Read))
            {
                byte[] arr = new byte[fs.Length];
                fs.Read(arr, 0, arr.Length);
                WriteLine(Encoding.UTF8.GetString(arr));

            }





        }
    }
}
