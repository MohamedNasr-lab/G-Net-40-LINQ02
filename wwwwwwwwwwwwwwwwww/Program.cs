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
            var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


            #endregion
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
