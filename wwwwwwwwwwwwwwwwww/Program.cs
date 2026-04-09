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
            //var result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Key}, Count: {item.Count()}");
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine($"   {product.ProductName}");
            //    }

            //}

            #endregion

            #region Q7
            //var result=Source.ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    ProductNames = g.Select(p => p.ProductName)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");

            //    foreach (var name in item.ProductNames)
            //    {
            //        Console.WriteLine($"   {name}");
            //    }
            //}
            #endregion

            #region Q8
            //var result = Source.ProductList.GroupBy(p => p.Category)
            // .Where(g => g.Count() > 3)
            // .Select(g => g.Key);

            //foreach(var category in result) 
            //   {
            //    Console.WriteLine(category);
            //}
            #endregion

            #region Q9
            //var result =
            //    from c in Source.CustomerList
            //    group c by c.Country into g
            //    select new
            //    {
            //        counter = g.Key,
            //        count = g.Count(),
            //        totalordervalue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //    };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Country: {item.counter}");
            //    Console.WriteLine($"Count: {item.count}");
            //    Console.WriteLine($"Total Order Value: {item.totalordervalue}");
            //    Console.WriteLine("------------------------");
            //}
            #endregion

            #region Q10

            #endregion

            #region Q11
            var CheapestPrice=Source.ProductList.Min(p=> p.UnitPrice);
            var ExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);
            Console.WriteLine(CheapestPrice);
            Console.WriteLine(ExpensivePrice);
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
