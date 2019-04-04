using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string
            Console.WriteLine("Madam, I'm Adam".IsPalindrom());
            Console.WriteLine("Madam, I am Adam".IsPalindrom());
            Console.WriteLine("Refer , refer!".IsPalindrom());

            //double
            Console.WriteLine(123.321.IsPalindrom());

            //int
            Console.WriteLine(11211.IsPalindrom());

            //long
            Console.WriteLine(12345654321.IsPalindrom()); 
            Console.ReadLine();
        }
    }
}
