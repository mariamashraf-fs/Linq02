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


        }
    }
}
