using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Genaraics.Genarics
{
    internal class MyArray
    {
      public  static void ReverseArrayListInPlace(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
      }
       public static void PrintArrayList(ArrayList list)
       {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
       }
    }
}
