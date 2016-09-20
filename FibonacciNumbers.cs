using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           // int n = int.Parse(Console.ReadLine());
            int firstFib = 1;
            int secondFib = 1;

            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    int result = firstFib + secondFib;
                    firstFib = secondFib;
                    secondFib = result;
                }
                Console.WriteLine(secondFib);
            }
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Math.Abs(a - b);
                
            I done fucked up
                // hahahahhahaha 
                //what is this 
            
            Console.ReadKey();
        }
    }
}
