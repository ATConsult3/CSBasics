using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using static andestech.learning.cs2022.utils.Utils;
using System.Collections.ObjectModel;

namespace andestech.learning.cs2022
{
    internal class CollectionsTest
    {
        static void Main(string[] args)
        {
            echo("Inventory Test"); WriteLine();

            List<string> inventoyIDs = new List<string> { "AA12356", "BC2768", "HH4879", "KH38793" };
            echo(inventoyIDs);
            var newIDs = inventoyIDs.Where(s => s.StartsWith("A"));
            echo(newIDs);

            echo("Linked LIst"); WriteLine();
            LinkedList<int> list = new LinkedList<int>( 
            new List<int>{1,2,-90,3,4,777,8,0,21});
            
            echo(list);

            int[] arr = list.ToArray();

            // sort linked list! long method
            List<int> list2 = new List<int>(list);
            list2.Sort();
            list = new LinkedList<int>(list2);
            echo(list);

            // sort linked list! Extension OrderBy
            var list3 =list.OrderBy(s => Math.Abs(s));
            echo(list3);

            // stack
            echo("Stack"); WriteLine();
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            echo(stack);
            int top = stack.Pop();
            echo(stack);

            echo("Queue"); WriteLine();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100); 
            queue.Enqueue(200);
            queue.Enqueue(300);
            echo(queue);
            top = queue.Dequeue();
            echo(queue);

            echo("Множества (Sets)"); WriteLine();
            HashSet<int> set = new HashSet<int>();
            set.Add(100);
            set.Add(30);
            set.Add(100);
            set.Add(-10);
            echo(set);

            echo("Словари (Dictionanry)"); WriteLine();
            Dictionary<String, int> greets = new Dictionary<String, int>
            { {"Hi" , 0 },
              {"Howdoyoudo", -2},
              {"Салют", 20},
              {"Hello", 5 }
            };

            greets["Hello"] = -50;
            greets.Add("Good Morning", 2);

            foreach (string key in greets.Keys) WriteLine($"{key} ---> {greets[key]}");
            echo("Sorted Greets"); WriteLine();
            var SortedGreets = greets.OrderBy(x => x.Key).Reverse().ToDictionary(x=> x.Key);
            foreach (string key in SortedGreets.Keys) WriteLine($"{key} ---> {SortedGreets[key]}");

         //   echo("Калькулятор"); WriteLine();

        }
    }
}
