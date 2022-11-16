using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace andestech.learning.cs2022
{

    class AccounException : Exception { 
    
     public AccounException(string message): base(message) {
        // code.....
        
        }

     // ....  
    
    }

    public class Account {
 
      private decimal _deposite;
      private static decimal MAX_DEPOSITE = 100_000, MIN_DEPOSITE = 10;
      public decimal Deposite
        { 
            get {return _deposite; }
            private set {
                if (value < MIN_DEPOSITE || value > MAX_DEPOSITE)
                    throw new AccounException($"Deposite out of bounds: {value}, transaction cancelled");
                _deposite = value; 
            }
        }
        public Account(decimal deposite) {
            Deposite = deposite;
        }

    
    }


    class Program
    {

        
     

        static void Main(string[] args)
        {
            string a = new String('a', 10);
            string b = "abc";
            string c = "abc"; // c = b
            b += "d";
            c += "d";
            WriteLine(b == c);
            WriteLine(Equals(b, c));
            WriteLine(b.Equals(c));
            WriteLine(ReferenceEquals(b, c));

            b = new String('a', 3);
            c = new String('a', 3);
            WriteLine(" --------------------------- ");

            WriteLine(b == c);
            WriteLine(Equals(b, c));
            WriteLine(b.Equals(c));
            WriteLine(ReferenceEquals(b, c));

            Object o;
            // User Exception test
            Account acc1 = new Account(10.1M);
            Account acc2 = new Account(9.99M);



            // Exception test

            try
            {
                int[] arr = new int[2];
                arr[1] = 11;
                // int data = int.Parse("123a");
                ArrayTest();


                // arr[2] = 111;
            }
            catch (
            IndexOutOfRangeException ex
            )
            {
                //log of exception
                WriteLine("--------- IndexOutOfRangeException -----------");
                WriteLine(ex.Message);
                WriteLine(ex.Source);
                WriteLine(ex.StackTrace);

                throw ex;

            }
            catch (FormatException ex)
            {

                WriteLine("--------- FormatException -----------");
                WriteLine(ex.Message);
                WriteLine(ex.Source);
                WriteLine(ex.StackTrace);

                throw ex;
            }
            catch (Exception ex)
            {

                WriteLine("--------- All Exceptions -----------");
                WriteLine(ex.Message);
                WriteLine(ex.Source);
                WriteLine(ex.StackTrace);

                throw ex;
            }

            finally {
                WriteLine("-------------- Finally block ------------");
            
            }



            WriteLine("End of Main");

        }

        static void ArrayTest() {
            int[] arr = new int[2];
            arr[1] = 11;
            arr[2] = 111;
        }
    }
}
