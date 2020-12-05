using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //1:
            Console.WriteLine(input[2]);
            //2:
            Console.WriteLine(input[input.Length - 2]);
            //3:
            Console.WriteLine(input.Substring(0, 5));
            //4:
            Console.WriteLine(input.Substring(0, input.Length - 2));
            //5:
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            //6:
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            //7:
            for (int i = 1; i <= input.Length; i++)
            {
                Console.Write(input[input.Length-i]);
            }
            Console.WriteLine();
            //8:
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(input[input.Length-i-1]);
                }
            }
            Console.WriteLine();
            //9:
            Console.WriteLine(input.Length);
            Console.ReadLine();
        }
    }
}
