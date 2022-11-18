using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning.cs2022
{
    internal class DynamicRun
    {
        private static Type Utype;

        static DynamicRun() {
            Assembly asm = Assembly.LoadFrom(
                      "C:\\Users\\sand\\source\\repos\\csharp_basics_2\\Day4_CS\\Utils\\bin\\Debug\\Utils.dll"
                      );
            Utype = asm.GetType("andestech.learning.cs2022.utils.Utils");

        }

        static void Echo(string name="-", char symb='-', uint N=75) {
            MethodInfo echo = Utype.GetMethod(
                      name: "echo",
                     types: new Type[] { typeof(string), typeof(char), typeof(uint) }
                                 );
            echo.Invoke(null, new object[] { name, symb, N });

        }

        static void Main(string[] args)
        {

            #region --- Выполнение стат кода из динамически подкл. сборки -----
            
                Assembly asm = Assembly.LoadFrom(
                    "C:\\Users\\sand\\source\\repos\\csharp_basics_2\\Day4_CS\\Utils\\bin\\Debug\\Utils.dll"
                    );
                //Type[] types = asm.GetTypes();
                //foreach (Type t in types) WriteLine(t.FullName);
                Type Utype = asm.GetType("andestech.learning.cs2022.utils.Utils");
                MethodInfo echo = Utype.GetMethod(
                   name: "echo",
                   //  bindingAttr: BindingFlags.Public | BindingFlags.Static,
                   types: new Type[] { typeof(string), typeof(char), typeof(uint) }
                    // ,modifiers : null, binder: null
                    );
                echo.Invoke(null, new object[] { "ECHO работает", '+', 77u });

            #endregion

            #region --- Выполнение кода экземпляра из динамически подкл. сборки -----
           
            Echo("Dynamic Lib Load");

            Assembly asm2 = Assembly.LoadFrom(
                    "C:\\Users\\sand\\source\\repos\\csharp_basics_2\\Day4_CS\\CollectionTest2\\" +
                    "bin\\Debug\\CollectionTest2.exe"
                    );
            //Type[] types = asm2.GetTypes();
            //foreach (Type t in types) WriteLine(t.FullName);
            Type type = asm2.GetType("andestech.learning.cs2022.library.Book2");
            
            object book = Activator.CreateInstance(
                  type: type,
                  args: new object[] { "Артур Конан-Дойль", "Затерянный Мир" }
                  );
            WriteLine(book);
            PropertyInfo id = type.GetProperty("ID", BindingFlags.Public | BindingFlags.Instance);
            WriteLine("Book id: " + id.GetValue(book));

            #endregion

        }
    }
}
