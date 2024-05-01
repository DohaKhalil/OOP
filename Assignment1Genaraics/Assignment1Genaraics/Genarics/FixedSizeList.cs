using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Genaraics.Genarics
{
    public class FixedSizeList<T> : List<T>
    {
        public FixedSizeList(int number)
        {
        }

        //Given a string, find the first non-repeated character in it and return its index.
        //If there is no such character, return -1. Hint you can use dictionary..

        public static int CharacterIndex(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1; 
        }

    }
}
