using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cslab1q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number for multiplication table");
            int n= int.Parse(Console.ReadLine());

            Console.WriteLine($"multiplication table of {n}");
            for(int i = 1; i<= 10; i++) 
            { 
                Console.WriteLine($"{n} x {i} = {n *i}");
            }
            Console.ReadLine();
        }
    }
}
