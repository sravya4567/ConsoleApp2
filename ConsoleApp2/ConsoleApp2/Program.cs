using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void FunsArray()
        {
            Array s;
            // Array ar;
            int[] ar1 = new int[] { 6, 45, 3, 22, 9 };
            Console.WriteLine("unsorted array is ");
            foreach (int i in ar1)
            {
                Console.WriteLine("values is " + i);
            }
            // array has sort()
            Array.Sort(ar1);// values automatically arrange in acs order a-z or 0-9
            Console.WriteLine("sorted array");
            foreach (var v in ar1) { Console.WriteLine("values in sorted array {0} ", v); }
        }
        static void Main(string[] args)
        {
            FunsArray();
            Console.ReadLine();
        }
    }
}

        
        
    

