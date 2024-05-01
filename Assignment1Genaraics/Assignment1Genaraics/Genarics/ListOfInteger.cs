using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Genaraics.Genarics
{
    public class ListOfInteger
    {

        public static List<int> MyInteger(List<int> ints)
        {
            var list = new List<int>(); 
            foreach (int number in ints)
            {
                if (number % 2 == 0)
                {
                    list.Add(number);
                }
            }
            return list;

        }

        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
