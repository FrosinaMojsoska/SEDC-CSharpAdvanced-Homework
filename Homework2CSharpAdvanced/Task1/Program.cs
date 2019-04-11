using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   static class Program
    {

        public static void Frequency<T>(this  T [] array)
        {
            T [] newArray = array.Distinct().ToArray();
            Console.WriteLine("The Frequency are:");
            foreach (var item in newArray)
            {
                T[] result = array.Where(x => x.Equals(item)).ToArray();
                Console.WriteLine($"{item} appears {result.Length} times");
            }
        }
        #region NumFrequency with method
        //public static void NumFrequency(int [] arrayInt)
        //{
        //    int[] newList = arrayInt.Distinct().ToArray();
        //    Console.WriteLine("The number and the Frequency are :");
        //    foreach (var item in newList)
        //    {
        //        int[] result = arrayInt.Where(x => x == item).ToArray();
        //        Console.WriteLine($"Number {item} appears {result.Length} times");
        //    }

        //}
        #endregion

        #region CharFrequency with method
        //public static void FString(string stringL)
        //{
        //    char[] listn = stringL.Distinct().ToArray();
        //    Console.WriteLine("The frequency of the characters are :");
        //    foreach (var item in listn)
        //    {
        //        char[] result = stringL.Where(x => x == item).ToArray();
        //        Console.WriteLine($"Character {item}:  {result.Length} times");
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            //int array
            int[] arrayInt = new int[] { 1, 5, 5, 9, 5, 9 };
            arrayInt.Frequency();
           
            //string
            string stringL = "apple";
            char[]stringArray=stringL.ToCharArray();
            stringArray.Frequency();
   


            Console.ReadLine();
        }
    }
}
