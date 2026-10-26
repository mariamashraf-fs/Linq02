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


        }
    }
}
