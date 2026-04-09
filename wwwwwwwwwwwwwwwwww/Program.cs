using static wwwwwwwwwwwwwwwwww.Source;
using static wwwwwwwwwwwwwwwwww.Product;
using static wwwwwwwwwwwwwwwwww.Customer;
using static wwwwwwwwwwwwwwwwww.Employee;
using static wwwwwwwwwwwwwwwwww.Order;
using static wwwwwwwwwwwwwwwwww.Student;

namespace wwwwwwwwwwwwwwwwww
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


            #endregion

            #region Q2
            //var result = Source.ProductList.Skip(5).Take(5).ToList();
            #endregion

            #region Q3
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Q4
            var x = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            Console.WriteLine(x);
            #endregion

            #region Q5

            #endregion


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
