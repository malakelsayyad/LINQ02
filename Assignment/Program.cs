using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using static Assignment.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            #region Restriction [Filteration] Operators

            //Q01

            //var OutOfStock = ProductList.Where(P => P.UnitsInStock==0);
            //foreach (var item in OutOfStock)
            //{
            //    Console.WriteLine(item);
            //}

            //Q02
            //var Products = ProductList.Where(P => P.UnitsInStock == 0).Where(P => P.UnitPrice > 3.00m);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item);
            //}

            //Q03
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((name, index) => name.Length < index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ELement Operators

            //Q01
            //var OutOfStock = ProductList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(OutOfStock?.ProductName ?? "NA");

            //Q02
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(result?.ProductName ?? "NA");

            //Q03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where(n => n > 5)
            //              .Skip(1)            
            //              .First();
            //Console.WriteLine(result);

            #endregion

            #region Aggregate Operators

            //Q01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var OddNumbersCount = Arr.Count(N => N % 2 == 1);
            //Console.WriteLine($"There is {OddNumbersCount} odd Numbers ");

            //Q02
            //var result =from C in CustomerList
            //            select new 
            //            {
            //               CustomerName=C.CustomerName,
            //               CustomerOrders=C.Orders.Count()
            //            };

            //foreach (var item in result)
            //{
            //    Console.WriteLine( item);
            //}

            //Q03
            //var result = from P in ProductList
            //             select new
            //             {
            //                 CategoryName = P.Category,
            //                 ProductCount= P.Category.Count(),
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =Arr.Count();
            //Console.WriteLine(result);

            //string filePath = @"D:\course\Backend\LINQ 02\dictionary_english.txt"; 

            //try
            //{
            //string[] words = File.ReadAllLines(filePath);

            //Q05
            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters in all words: {totalCharacters}");

            //Q06
            //int ShortestWord = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word : {ShortestWord}");

            //Q07
            //int LongestWord = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word : {LongestWord}");

            //Q08
            //double AvgLength = words.Average(word => word.Length);
            //Console.WriteLine($"Average Length of words : {AvgLength}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}


            //Q09
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //               select  new
            //               {
            //                 CategoryName = Group.Key,
            //                 UnitsInStock = Group.Sum(P=>P.UnitsInStock)                      
            //               };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q10
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 CheapestPriceInThisCategory = Group.Min(P=>P.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q11
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let CheapestPriceInThisCategory = Group.Min(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 CheapestProduct = CheapestPriceInThisCategory
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q12
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 MostExpensivePrice = Group.Max(P => P.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q13
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let maxPrice = Group.Max(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 MostExpensiveProducts = Group.Where(P => P.UnitPrice == maxPrice).ToList()
            //             };
            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.CategoryName);
            //    foreach (var item in Category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"{item.ProductName} : {item.UnitPrice}");
            //    }
            //}

            //Q14
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let AvgPrice = Group.Average(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 AveragePrice = AvgPrice,
            //             };
            //foreach (var Category in result)
            //{
            //    Console.WriteLine($"Category Name : {Category.CategoryName} --> Average Price = {Category.AveragePrice:C}");
            //}

            #endregion

            #region Ordering Operators

            //Q01
            //var result = ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q02
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w, new ComparerListCaseInsenstive()).ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q03
            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q04
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(A => A.Length)
            //                .ThenBy(A=>A)
            //                .ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q05
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(A => A.Length) 
            //                .ThenBy(A => A, StringComparer.OrdinalIgnoreCase) 
            //                .ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q06
            //var result  = from P in ProductList
            //              orderby P.Category , P.UnitPrice descending
            //              select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q07
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(A => A.Length)
            //    .ThenByDescending(A => A, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q08
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(A => A.Length > 1 && A[1] == 'i') 
            //    .Reverse() 
            //    .ToList(); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation Operators

            //Q01
            //var result = ProductList.Select(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q02
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    Uppercase = w.ToUpper(),
            //    Lowercase = w.ToLower()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Uppercase: {item.Uppercase}, Lowercase: {item.Lowercase}");
            //}

            //Q03
            //var result = from P in ProductList
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.ProductID,
            //                 P.Category,
            //                 Price = P.UnitPrice,
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((N,I)=> new { Number = N, Index = I, IsMatch = N == I });
            //Console.WriteLine("Number : In-Place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.IsMatch}");
            //}

            //Q05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //Console.WriteLine("Pairs where a < b :");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            //Q06
            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.Total > 500
            //             select O;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item}");
            //}

            //Q07
            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.OrderDate >= new DateTime(1998, 1, 1)
            //             select O;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item}");
            //}

            #endregion

            #region Set Operators

            //Q01
            //var result = ProductList.Select(P=>P.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q02
            //var ProductUnique = ProductList.Select(P => P.ProductName[0]);
            //var CustomerUnique = CustomerList.Select(C => C.CustomerName[0]);

            //var BothUnique = ProductUnique.Union(CustomerUnique).Distinct();
            //foreach (var item in BothUnique)
            //{
            //    Console.WriteLine(item);
            //}

            //Q03
            //var ProductFirst = ProductList.Select(P => P.ProductName[0]);
            //var CustomerFirst = CustomerList.Select(C => C.CustomerName[0]);

            //var Intersection = ProductFirst.Intersect(CustomerFirst)=;
            //foreach (var item in Intersection)
            //{
            //    Console.WriteLine(item);


            //Q04
            //var ProductFirst = ProductList.Select(P => P.ProductName[0]);
            //var CustomerFirst = CustomerList.Select(C => C.CustomerName[0]);

            //var Except = ProductFirst.Except(CustomerFirst);
            //foreach (var item in Except)
            //{
            //    Console.WriteLine(item);
            //}

            //Q05
            //var productLastThreeChars = ProductList .Select(P => new string(P.ProductName.TakeLast(3).ToArray()));
            //var customerLastThreeChars = CustomerList .Select(C => new string(C.CustomerName.TakeLast(3).ToArray()));

            //var Concat = productLastThreeChars.Concat(customerLastThreeChars);
            //foreach (var item in Concat)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  Partitioning Operators

            //Q01
            //var result = (from C in CustomerList
            //              where C.Address == "Washington"
            //              from O in C.Orders
            //              select O).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q02
            //var result = (from C in CustomerList
            //              where C.Address == "Washington"
            //              from O in C.Orders
            //              select O).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number, index) => number >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=numbers.SkipWhile(N=>N%3==0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q05
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((number, index) => number >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Quantifiers Operators

            //Q01
            //string filePath = @"D:\course\Backend\LINQ 02\dictionary_english.txt";  

            //try
            //{
            //    string[] words = File.ReadAllLines(filePath);

            //    //var contains = words.Contains("ei");
            //    //Console.WriteLine($"Contains substring [ei] ? : {contains}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}

            //Q02
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             where Group.Any(P=>P.UnitsInStock==0)
            //             select new
            //             {
            //                 Category = Group.Key,
            //                 Products = Group
            //             };

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach (var item in group.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Q03
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             where Group.All(P => P.UnitsInStock > 0)
            //             select new
            //             {
            //                 Category = Group.Key,
            //                 Products = Group
            //             };

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach (var item in group.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            #endregion

            #region Grouping Operators

            //Q01
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach (var number in item)
            //    {
            //        Console.WriteLine($"{number} ");
            //    }
            //}

            //Q02
            //string filePath = @"D:\course\Backend\LINQ 02\dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Where(word => !string.IsNullOrWhiteSpace(word)) 
            //                  .GroupBy(word => char.ToUpper(word[0])) 
            //                  .OrderBy(group => group.Key);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words that start with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.Write($"{word} ");
            //    }
            //}

            //Q03
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.Select(word => word.Trim()) 
            //                .GroupBy(word => new string(word.OrderBy(c => c).ToArray())) 
            //                .ToList();
            //foreach (var group in result)
            //{
                
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"{word} ");
            //    }
                
            //}
            #endregion

        }
    }
}
