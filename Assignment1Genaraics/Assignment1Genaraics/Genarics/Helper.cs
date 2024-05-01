using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Genaraics.Genarics
{
    internal class Helper<T> where T : IComparable<T>
    {
        #region *1
        //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
        //which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
        //And implement the code of this optimized bubble sort algorithm
        //==================================================================================
        //Bubble sort algorithm can be optimized by observing that all
        //elements after the last swap are sorted so there is no need to check them again
        public static void BubbleStore(T[] arr )
        {
            if( arr is not null )
            {
                for( int i = 0; i < arr.Length; i++ )
                {
                    for ( int j = 0; j<arr.Length-1; j++ )
                    {
                        if (arr[j].CompareTo(arr[j+1])==1)
                        {
                          Swap(ref arr[j], ref arr[j+1]);

                        }

                    }
                }
            }

        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void PrintArray (int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        #endregion



    }



}
