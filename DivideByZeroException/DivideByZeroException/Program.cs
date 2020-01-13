using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DivideByException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = null;
                sr = File.OpenText(@"F:\data.txt");

                Console.WriteLine(sr.ReadToEnd());

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int res = num1 / num2;

                Console.WriteLine(res);
            }
            catch (DivideByZeroException de) {    
            Console.WriteLine("Your File is not in Correct Location");
            }

            Console.ReadLine();
        }
    }
}
