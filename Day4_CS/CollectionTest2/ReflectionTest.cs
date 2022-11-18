#define LOGGER2
#define LOGGER3
#undef TRACE

using System.Threading.Tasks;
using static andestech.learning.cs2022.utils.Utils;
using System.Collections.ObjectModel;
using static System.Console;
using andestech.learning.cs2022.library;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using System;

namespace andestech.learning.cs2022
{
    internal class ReflectionTest
    {
        public static void Main()
        {
            echo("Reflection & Flags test");

            F1();
            int i = 1;
            Debug.Assert(i == 1, $"Debug: Hi, i={i}");
            Trace.Assert(i == 3, $"Trace: Hi, i={i}");

            Type type = typeof(Book);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo prop in props) WriteLine(prop.Name + "---->" + prop.PropertyType +
                " -->" + prop.Module);


            Book book1 = new Book { Author = "А.Толстой", Title = "Аэлита" };
            FieldInfo f1 = type.GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            WriteLine("ID=" + book1.ID);
            f1.SetValue(book1, 1);
            WriteLine("ID=" + book1.ID);

            // --- Lib loader test
            echo("List of System.dll types...");
            Assembly assembly = Assembly.LoadFrom(
                "C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.8\\System.dll"
                );
            Type[] types = assembly.GetTypes();
            foreach (Type t in types) WriteLine(t.FullName);
           




#if LOGGER3
            F2();
#endif
#if DEBUG
            WriteLine("DEBUG CODE TEST");
#endif
#if TRACE
            WriteLine("TRACE CODE TEST");
#endif

        }

        [Conditional("LOGGER1")]
        [Conditional("LOGGER2")]
        private static void F1() { WriteLine("+++ F1");}

#if LOGGER3
       private static int F2() { WriteLine("+++ F2!!!!"); return 0;}
#endif

    }
}
