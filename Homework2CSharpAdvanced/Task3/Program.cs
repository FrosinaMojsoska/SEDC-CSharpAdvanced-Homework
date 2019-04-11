using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of members on the List: ");
            int NumberMembers = Convert.ToInt32(Console.ReadLine());
            List<int> ListInt = new List<int>();
            for(int i=0;i<NumberMembers;i++)
            {
                Console.WriteLine($"Enter member {i} : ");
                ListInt.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("Input the value above you want to display the members of the List : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            List<int> resultList = new List<int>();
            resultList = ListInt.Where(x => x > value).ToList();
            Console.WriteLine($"The numbers greater than {value} are:");
            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
