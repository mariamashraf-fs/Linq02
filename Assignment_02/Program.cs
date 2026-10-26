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

            #region Question08

            //// 8. show page 2 of products, with page size= 5

            //int pageNumber = 2;
            //int pageSize = 5;

            //var q8 = products.Skip((pageNumber - 1) * pageSize)
            //                 .Take(pageSize);

            //foreach (var item in q8)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}");
            //}

            #endregion

            #region Question09

            //// 9. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var q9 = products.OrderBy(p => p.UnitPrice)
            //                 .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var item in q9)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion

            #region Question10

            //// 10. Check if ALL products in the"Seafood" category are in stock

            //var q10 = products.Where(p => p.Category == "Seafood")
            //                  .All(p => p.UnitsInStock > 0);

            //Console.WriteLine($"Are all Seafood products in stock?  => {q10}");

            #endregion

            #region Question11

            //// 11. Check if the ID list contains 9 int[] ids={ 3, 9, 13, 18};

            //int[] ids = { 3, 9, 13, 18 };

            //var q11 = ids.Contains(9);

            //Console.WriteLine($"Does the ID list contain 9? => {q11}");

            #endregion

            #region Question12

            //// 12. Group all products by Category and print each group with its product count.

            //var q12 = products.GroupBy(p => p.Category);

            //foreach (var group in q12)
            //{
            //    Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
            //}

            #endregion

            #region Question13

            //// 13. Group products by Category and project only product names per group

            //var q13 = products.GroupBy(p => p.Category)
            //                  .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });

            //foreach (var group in q13)
            //{
            //    Console.WriteLine($"Category: {group.Category}");

            //    foreach (var name in group.Names)
            //    {
            //        Console.WriteLine($"     {name}");
            //    }
            //}

            #endregion

            #region Question14

            //// 14. Find all categories that have MORE THAN 3 products

            //var q14 = products.GroupBy(p => p.Category)
            //                  .Where(g => g.Count() > 3)
            //                  .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in q14)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Count: {item.Count}");
            //}

            #endregion

            #region Question15

            //// 15. Using QUERY SYNTAX, group customers by Country, and for each group select{ Country, Count, TotalOrderValue}.

            //var q15 = from c in customers
            //          group c by c.Country into g
            //          select new
            //          {
            //              Country = g.Key,
            //              Count = g.Count(),
            //              TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //          };

            //foreach (var item in q15)
            //{
            //    Console.WriteLine($"Country: {item.Country}, Count: {item.Count}, TotalOrderValue: {item.TotalOrderValue:N2}");
            //}

            #endregion

            #region Question16

            //// 16. Calculate the total number of units in stock across all products

            //var q16 = products.Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total Units In Stock: {q16}");

            #endregion

            #region Question17

            //// 17. Find the CHEAPEST and MOST EXPENSIVE product prices

            //var q17_cheapestPrice = products.Min(p => p.UnitPrice);
            //var q17_mostExpensivePrice = products.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Price: {q17_cheapestPrice}, Most Expensive Price: {q17_mostExpensivePrice}");

            #endregion

            #region Question18

            //// 18. Get a distinct list of all product categories

            //var q18 = products.Select(p => p.Category)
            //                  .Distinct()
            //                  .ToList();

            //foreach (var category in q18)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Question19

            //// 19. find product IDs that are in setA but NOT in setB int[] setA={ 1, 3, 5, 7, 9, 11, 13}; int[] setB={ 3, 6, 9, 12, 15, 13};

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var q19 = setA.Except(setB);

            //foreach (var id in q19)
            //{
            //    Console.WriteLine(id);
            //}

            #endregion



        }
    }
}
