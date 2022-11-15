using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning.cs2022
{
    enum FileMode {
    noaccess = 0,
    read =    0x04,
    write =   0x02,
    execute = 0x01 // 0x08, 0x10
    }


    internal class Program
    {

        static void ProcessFile(string name, FileMode fmode)
        {
            switch (fmode)
            {
            case FileMode.noaccess:
                    WriteLine($"No access to file \"{name}\".");
                    break;

            case FileMode.read:
                    WriteLine($"Process file \"{name}\" as Read.");
                    break;
            case FileMode.write:
                    WriteLine($"Process file \"{name}\" as Write.");
                    break;
            case FileMode.write | FileMode.read:
                    WriteLine($"Process file \"{name}\" as Read & Write.");
                    break;
            case FileMode.execute:
                    WriteLine($"Process file \"{name}\" to Execute.");
                    break;
            default:
                    string msg = $"Regime {fmode} ignored";
                    WriteLine(msg);
                    throw new Exception(msg);
                   // break;

            }
        
        
        }

        private static void EnumTest() {

            ProcessFile("data.txt", FileMode.write);

            ProcessFile("data2.txt", FileMode.write | FileMode.read);

            // ProcessFile("data3.txt", (FileMode)8); // Exception!
            // ProcessFile("ls2", FileMode.read | FileMode.execute); // Exception!

            ProcessFile("ls", FileMode.execute);

        }


        static void Main(string[] args)
        {
            WriteLine("----- Test enums, switch|case, loops");
            EnumTest();


            WriteLine("----- End of Main ------");
        }
    }
}
