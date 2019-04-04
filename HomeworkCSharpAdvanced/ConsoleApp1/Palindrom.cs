using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Palindrom
    {
        #region methodPalindromCheck
        public static bool IsPalindrom(char[] Array)
        {
            char first = ' ';
            char last = ' ';

            #region ifTheLengthIsEvenNumber
            if (Array.Length % 2 == 0)
            {
                int i = 0;
                int j = Array.Length - 1;
                int counter = Array.Length / 2;
                while (counter > 0)
                {
                    if (i < Array.Length / 2)
                    {
                        first = Array[i];
                    }
                    if (j > (Array.Length / 2) - 1)
                    {
                        last = Array[j];
                    }
                    if (first != last)

                        return false;

                    else
                    {
                        i++;
                        j--;
                    }
                    counter--;
                }
                return true;
            }
            #endregion

            #region IfTheLenghtIsOddNumber
            else
            {
                int i = 0;
                int j = Array.Length - 1;
                int counter = Array.Length / 2;
                while (counter > 0)
                {
                    if (i < Array.Length / 2)
                    {
                        first = Array[i];
                    }
                    if (j > Array.Length / 2)
                    {
                        last = Array[j];
                    }
                    if (first != last)

                        return false;

                    else
                    {
                        i++;
                        j--;
                    }
                    counter--;
                }
                return true;
            }
            #endregion
        }
        #endregion

        #region IsPalindromForString
        public static bool IsPalindrom(this string text)
        {
            char[] textList = text.ToLower().ToCharArray();
           
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char item in textList)
            {
               if (Char.IsLetter(item))
                {
                    stringBuilder.Append(item);
                }
            }
            string stringText = stringBuilder.ToString();
            char[] finalText = stringText.ToCharArray();
            return IsPalindrom(finalText);
            
        }
        #endregion

        #region IsPalindromForDoubleNumber
        public static bool IsPalindrom(this double number)
        {
            
            //dokolku 123.21 ili 44.444 ne e palindrom togas ke ja ima i proverkata vo zakomentiraniot del :D
            //string celiotString = number.ToString();
            //string[] podelen = celiotString.Split('.');
            //if(podelen[0].Length!=podelen[1].Length)
            //{
            //  return false;
            //}
            //else
            //{
                char[] numberList = number.ToString().Replace(".", "").ToCharArray();
                return IsPalindrom(numberList);
            //}
      
        }
        #endregion

        #region IsPalindromForIntNumber
        public static bool IsPalindrom(this int number)
        {
            char[] numberList = number.ToString().ToCharArray();
            return IsPalindrom(numberList);
        }
        #endregion

        #region IsPalindromForLongNumber
        public static bool IsPalindrom (this long number)
        {
            char[] numberList = number.ToString().ToCharArray();
            return IsPalindrom(numberList);
        }
        #endregion


    }
}
