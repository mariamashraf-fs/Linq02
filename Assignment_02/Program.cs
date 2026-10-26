using LINQ.DataSources;
using LINQ.Models;
using System.Linq;


namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;
            var customers = Source.CustomerList;

            #region Question01

            //// 1.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var q1 = products.OrderBy(p => p.Category)
            //         .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion

            #region Question02

            //// 2. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var q2 = products.Where(p => p.Category == "Beverages")
            //                 .OrderByDescending(p => p.UnitsInStock)
            //                 .Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var item in q2)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            //}

            #endregion

            #region Question03

            //// 3. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            //var q3 = from c in customers
            //         from o in c.Orders
            //         where o.OrderDate.Year >= 1997
            //         select new { c.CustomerID, o.OrderDate };

            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate:yyyy-MM-dd}");
            //}

            #endregion

            #region Question04

            //// 4. Show position number alongside ProductName

            //var q4 = products.Select((p, index) =>
            //                new { Position = index + 1, p.ProductName });

            //foreach (var item in q4)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}

            #endregion

            #region Question05

            //// 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //// String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var q5 = Arr.OrderBy(w => w.Length)
            //            .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in q5)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Question06

            //// 6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var q6 = digits.Where(d => d.Length > 1 && d[1] == 'i')
            //               .Reverse()
            //               .ToList();

            //foreach (var digit in q6)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region Question07

           //// 7.Get top 3 most expensive products

           //var q7 = products.OrderByDescending(p => p.UnitPrice)
           //                 .Take(3);

           // foreach (var item in q7)
           // {
           //     Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
           // }

            #endregion



        }
    }
}
