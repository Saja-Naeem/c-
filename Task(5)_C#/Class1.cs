using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_5__C_
{
    internal class Class1
    {
        public void print1(string msg)
        {
            Console.WriteLine(msg);
        }
        public void print2(string name)
        {
            Console.WriteLine($"Hello All, I am {name}");
        }
        public int factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return (x * factorial(x - 1));
        }
        public int[] PrintSortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr; 
        }
        
    }
}
