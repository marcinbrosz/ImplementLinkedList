using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-generic LinkedList\n");
            MyLinkedList testList = new MyLinkedList();
            
            for(int i = 0; i < 5; i++)
            {
                testList.Add(i);
            }

            foreach (int i in testList)
                Console.WriteLine(i);

            Console.WriteLine("Generic LinkedList\n");
            GenericMyLinkedList<int> testGenList = new GenericMyLinkedList<int>();


            for (int i = 98; i < 101; i++)
            {
                testGenList.AddLast((int)i);
            }

            foreach (int i in testGenList)
                Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
