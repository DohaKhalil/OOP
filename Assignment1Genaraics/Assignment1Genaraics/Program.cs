// See https://aka.ms/new-console-template for more information


using Assignment1Genaraics.Genarics;
using System.Collections;

namespace Assignment1Genaraics
{

    class Program
    {


        static void Main(string[] args) 
        {
            #region Rnge
            Range<int> range = new Range<int>(50, 60);
        

            Console.WriteLine($"the number in Range? :   {range.IsRange(55)}");
            Console.WriteLine($"the number in Range? :   {range.IsRange(30)}");

            Range<int> newrange = new Range<int>(58, 70);

            Console.WriteLine($"the number in Range? :   {newrange.IsRange(55)}");
            Console.WriteLine($"the number in Range? :   {newrange.IsRange(30)}");

          int NweLenth = Range<int>.Length(99, 50);
            Console.WriteLine(NweLenth);
            #endregion

            #region BubbleStore
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Console.WriteLine("Original array:");
            //Helper<int>.PrintArrayList(arr);
            //Helper<int>.BubbleStore(arr);
            //Console.WriteLine("\nSorted array:");
            //Helper<int>.PrintArrayList(arr);
            #endregion

            #region MyArray
            //ArrayList myArrayList = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original ArrayList:");
            //MyArray.PrintArrayList(myArrayList);

            //MyArray.ReverseArrayListInPlace(myArrayList);

            //Console.WriteLine("\nReversed ArrayList:");
            //MyArray.PrintArrayList(myArrayList);
            #endregion

            #region MyIntger
            //You are given a list of integers.
            //Your task is to find and return
            //a new list containing only the even numbers from the given list.

            //List<int> mylist = new List<int> { 1, 2, 3 , 4 , 5  };
            //ListOfInteger.PrintList(mylist);
            //List<int> evenNumbersList =ListOfInteger.MyInteger(mylist);
            //ListOfInteger.PrintList(evenNumbersList);

            #endregion


            #region FixedSize;

            FixedSizeList<int> ints = new FixedSizeList<int>(20);

            Console.WriteLine($"Ints = {ints.Count} , Capacity  = {ints.Capacity}");

            try
            {   
                ints.Add(7);
                ints.Add(8);
                ints.Add(9);
                ints.Add(10);
                ints.Add(11);
                ints.Add(12);    
                ints.Add(13);
                ints.Add(14);


                Console.WriteLine("Elements in the list:");

                foreach (int i in ints)
                {
                 Console.WriteLine(i);
                }
                

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            Console.WriteLine($"Ints = {ints.Count} , Capacity  = {ints.Capacity}");

            //Implement a Get method that retrieves an element at
            //a specific index in the list but throws an exception for invalid indices.

            Console.WriteLine("Accessing elements by index:");
            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine($"Index {i}: {ints[i]}");
            }

            string userInput = "ddohaaissamkhalil";
            Console.WriteLine(userInput);
            int Char = FixedSizeList<string>.CharacterIndex(userInput);
            if (Char != -1)
            {
                Console.WriteLine($"The first non-repeated character in the string \"{userInput}\" is at index {Char}.");
            }
            else
            {
                Console.WriteLine("No non-repeated character found in the string.");
            }




            #endregion
        }


    }
}