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
            //var x = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(x);
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };

            //var x = ids.Contains(9);
            //Console.WriteLine(x);
            #endregion

            #region Q6
            var result = Source.ProductList.GroupBy(p => p.Category);
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Key}, Count: {item.Count()}");
                foreach (var product in item)
                {
                    Console.WriteLine($"   {product.ProductName}");
                }

            }

            #endregion

            #region Q7

            #endregion

            #region Q8

            #endregion

            #region Q9

            #endregion

            #region Q10

            #endregion

            #region Q11

            #endregion

            #region Q12

            #endregion

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
