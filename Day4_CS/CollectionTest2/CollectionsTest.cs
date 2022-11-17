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

            // sort linked list!
            List<int> list2 = new List<int>(list);
            list2.Sort();
            list = new LinkedList<int>(list2);
            echo(list);

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





        }
    }
}
