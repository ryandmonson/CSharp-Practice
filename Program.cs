using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPracticeCSharp
{
    public class Program
        /* 
         These are all CodeWars challenges written in C#.
         */
    {
        static void Main()
        {
            
            /*
             This is to 1) order an array alphabetically (accounting for capital 1st letters,
            2) take the 1st element of the array and return that element with  *** between
            each character
            */
            string[] s = { "fLEroLQX", "BXFJ", "gYO", "UmWmcNo", "biRF", "xkxi", "SoZuG", "oaEomiNS" };
            Array.Sort(s, StringComparer.Ordinal);
            string finalString = "";
            for (int i = 0; i < s[0].Length - 1; i++)
            {
                finalString += s[0][i] + "***";
            }
                finalString += s[0][s[0].Length-1];
                Console.WriteLine(finalString);

            /*
             take a value and returns a list of its multiples up to another value. 
            If limit is a multiple of integer, it should be included as well. 
            There will only ever be positive integers passed into the function,
            not consisting of 0. The limit will always be higher than the base.
            if the parameters passed are (2, 6), the function should return [2, 4, 6] 
            as 2, 4, and 6 are the multiples of 2 up to 6.
                If you can, try writing it in only one line of code.
             */

            List<int> n = new List<int>() { 2, 6 };
            List<int> nMult = new List<int>();

            for (int i = n[0]; i <= n[1]; i++)
            {
                if (i % n[0] == 0)
                {                   
                    nMult.Add(i);
                }
            }
            nMult.ForEach(Console.Write);

            //Complete the function that takes two integers(a, b, where a < b) and return
            //an array of all integers between the input parameters, including them.

            static int[] Between (int a, int b)
            {
                List<int> myList = new List<int>();
                for (int i=0; i <= (b-a); i++ )
                {
                    myList.Add(a + i);
                }
                Console.WriteLine();
                myList.ForEach(Console.Write);
                return myList.ToArray();
            }

            Between(2, 8);

            // Convert US Dollars into Yuan

            static decimal ustoyuan (decimal dollar)
            {
                decimal yuan = 6.75m*dollar;
                return yuan;

            }
            Console.WriteLine();
            Console.WriteLine(ustoyuan(2));
            /*
            Timmy & Sarah think they are in love, but around where they live, 
            they will only know once they pick a flower each. If one of the flowers 
            has an even number of petals and the other has an odd number of petals 
            it means they are in love.

            Write a function that will take the number of petals of each flower and 
            return true if they are in love and false if they aren't.
            */

           static bool lovefunc(int flower1, int flower2)
            {
                if ((flower1 % 2 != 0 && flower2 % 2 == 0) || (flower1 % 2 == 0 && flower2 % 2 != 0))
                {
                    return true;
                } else
                {
                    return false;
                }             
            }
            Console.WriteLine(lovefunc(2, 3));

            //Create a function that accepts 2 string arguments and returns an integer 
            //of the count of occurrences the 2nd argument is found in the first one.

            static int StrCount(string str, string letter)
            {
                int count = 0;
                for (int i = 0; i<str.Length; i++)
                {
                    if (str[i].ToString() == letter)
                    {
                        count += 1;
                    }
                }
                return count;
            }
            Console.WriteLine(StrCount("Hello", "l"));

            /* Given 2 strings, a and b, return a string of the form short+long+short, 
             with the shorter string on the outside and the longer string on the inside. 
             The strings will not be the same length, but they may be empty ( zero length ).
            */

            static string LongShort(string a, string b)
            {
                if (a.Length > b.Length)
                {
                    return b + a + b;
                }
                return a + b + a;
            }
            Console.WriteLine(LongShort("1", "22"));

            /*You will be given an array a and a value x.
            All you need to do is check whether the provided array 
            contains the value.Array can contain numbers or strings. 
            X can be either.Return true if the array contains the value, 
            false if not.*/

            static bool Check(object[] a, object x)
            {
                return a.Contains (x);
            }
            Console.WriteLine(Check(new object[] { 66, 101 }, 66));

        }
    }
}
