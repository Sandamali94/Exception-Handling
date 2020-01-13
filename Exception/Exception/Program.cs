using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception
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
            }
            catch(FileNotFoundException fx)
            {
                Console.WriteLine("Your File is not in Correct Location");
            }
                         
            Console.ReadLine();

        }
    }
}

