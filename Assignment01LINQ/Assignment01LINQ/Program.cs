
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using static Assignment01LINQ.ListGenorator;



namespace Assignment01LINQ
{
    class progarm
    {

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            //    //1.Find all products that are out of stock.

            //var Result = ProductsList.Where(producte => producte.UnitsInStock == 0);
            //foreach (var item in Result)
            //{

            //    Console.WriteLine(item);
            //}

            //    //2.Find all products that are in stock and cost more than 3.00 per unit.
            //    var Result2 = ProductsList.Where(producte => producte.UnitsInStock > 0 == producte.UnitPrice > 3);
            //    foreach (var item in Result2)
            //    {

            //        Console.WriteLine(item);
            //    }

            //    //3. Returns digits whose name is shorter than their value.

            //    String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //    int [] ResultArr = new int[Arr.Length];
            //    if (Arr.Length > 0)
            //    {
            //        for (int i = 0; i < Arr.Length; i++)
            //        {
            //            if (Arr[i].Length < i)
            //            {
            //                ResultArr[i] = i;
            //            }
            //        }
            //        Console.WriteLine("Digits whose name is shorter than their value:");
            //        for (int i = 0; i < ResultArr.Length; i++)
            //        {
            //            if (ResultArr[i] != 0) 
            //            {
            //                Console.WriteLine(ResultArr[i]);
            //            }
            //        }

            //    }

            //}

            #endregion


            #region LINQ-Element Operators
            ////1.Get first Product out of Stock

            //var Result3 = ProductsList.FirstOrDefault((p) => p.UnitsInStock==0);
            //if (Result3 != null)
            //{
            //    Console.WriteLine(Result3);
            //}

            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (result != null)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("null");
            //}

            ////3. Retrieve the second number greater than 5 

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondGreaterThan5 = arr.Where(x => x > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(secondGreaterThan5 != 0 ? secondGreaterThan5.ToString() : "No such number found.");


            #endregion


            #region LINQ - Aggregate Operators
            ////1. Uses Count to get the number of odd numbers in the array
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddCount = arr.Count(x => x % 2 != 0);

            //Console.WriteLine("Number of odd numbers: " + oddCount);

            ////2. Return a list of customers and how many orders each has.
            //var customersWithOrderCount = CustomersList.Select(customer => new { Customers = customer, OrderCount = customer.Orders.Count()}); ;

            //foreach (var item in customersWithOrderCount)
            //{
            //    Console.WriteLine($"Customer: {item.Customers.CustomerName}, Orders: {item.OrderCount}");
            //}

            ////3. Return a list of categories and how many products each has
            //var Categorey = ProductsList.Select(category => new { ProductNman = category.ProductName, CategoryCount = category.Category.Count()}) ;
            //foreach (var item in Categorey)
            //{
            //    Console.WriteLine($"The Product Name :{item.ProductNman} , CountOfCatrgory {item.CategoryCount}");
            //}

            ////4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result6 = Arr.Sum(x => x);
            //Console.WriteLine(Result6);

            ////5. Get the total number of characters of all words
            ////in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] line = File.ReadAllLines(@"C:\Users\hp\source\repos\Assignment01LINQ\Assignment01LINQ\dictionary_english.txt");
            //string[] words = line.SelectMany(line => line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)).ToArray();
            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine(totalCharacters);
            //Console.WriteLine(words);

            ////6. Get the length of the shortest word in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).
            //string[] line1 = File.ReadAllLines(@"C:\Users\hp\source\repos\Assignment01LINQ\Assignment01LINQ\dictionary_english.txt");
            //int shortestLength = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word: {shortestLength}");

            ////7. Get the length of the longest word in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).
            //string[] line2 = File.ReadAllLines(@"C:\Users\hp\source\repos\Assignment01LINQ\Assignment01LINQ\dictionary_english.txt");
            //int MaxLength2 = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the Max word: {MaxLength2}");

            ////8. Get the average length of the words in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).
            //string[] line3 = File.ReadAllLines(@"C:\Users\hp\source\repos\Assignment01LINQ\Assignment01LINQ\dictionary_english.txt");
            //double AveregeLength3 = words.Average(word => word.Length);
            //Console.WriteLine($"Length of the Averegge word: {AveregeLength3}");
            #endregion

            #region LINQ - Ordering Operators
            ////1. Sort a list of products by name
            //var OrderByName = ProductsList.OrderBy(product => product.ProductName);
            //foreach (var item in OrderByName)
            //{
            //    Console.WriteLine(item);

            //}

            ////2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var ComparString = Arr.OrderBy(word => word , StringComparer.OrdinalIgnoreCase);
            //foreach (var item in ComparString)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Sort a list of products by units in stock from highest to lowest.

            //var ProductsInStock = ProductsList.OrderByDescending(FromHighth => FromHighth.UnitsInStock);
            //foreach (var item in ProductsInStock)
            //{
            //    Console.WriteLine(item);

            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var strings = Arr.OrderBy(x  => x.Length).ThenBy(name => name);
            //foreach (var item in strings)
            //{
            //    Console.WriteLine(item);

            //}

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var WordLenth = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in WordLenth)
            //{
            //    Console.WriteLine(item);
            //}

            ////6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var ListOfProduct = ProductsList.OrderBy(categorylist => categorylist.Category).ThenByDescending(pric => pric.UnitPrice);
            //foreach (var item in ListOfProduct)
            //{
            //    Console.WriteLine(item); 
            //}

            ////7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var ByWordLenght = Arr.OrderBy(Arr => Arr.Length).ThenByDescending(arr => arr, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);

            //}
            //8. Create a list of all digits in the array whose second letter is 'i'
            //that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var NewArr = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();
            //foreach (var item in NewArr)
            //{
            //    Console.WriteLine(item);   
            //}
            #endregion

            #region LINQ – Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            var NamOfProductSelect = ProductsList.Select(Name => Name.ProductName);
            foreach (var product in NamOfProductSelect)
            {
                Console.WriteLine(product);
            }
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original
            //array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var UpperAnLowerChar = words.Select(newWord => new { UpperCharter = newWord.ToUpper(), LowrCharter = newWord.ToLower() });
            foreach (var item in UpperAnLowerChar)
            {
                Console.WriteLine(item);
            }
            //3. Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

            var NwePrducte = ProductsList.Select(P => new {ProductName = P.ProductName , ProductPrice = P.UnitPrice , ProducteInStok= P.UnitsInStock});
            foreach (var item in NwePrducte)
            {
                Console.WriteLine(item);
            }
            //4. Determine if the value of int in an array match their position in the array.
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            bool allMatch = Arr.Select((value, index) => value == index).All(match => match);
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"Index {i}: {allMatch}");
            }
            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is
            //less than the number from numbersB
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var SelectFromTwoArry = numbersA.SelectMany(A => numbersB.Select(B => new { NumberA = A, NumberB = B })).Where(pair => pair.NumberA < pair.NumberB);
            foreach (var pair in SelectFromTwoArry)
            {
                Console.WriteLine($"({pair.NumberA} > {pair.NumberA})");

            }


            #endregion


        }
    }
}