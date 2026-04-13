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
            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);
            #endregion

            #region Q11
            //var CheapestPrice=Source.ProductList.Min(p=> p.UnitPrice);
            //var ExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(CheapestPrice);
            //Console.WriteLine(ExpensivePrice);
            #endregion

            #region Q12
            //var result = Source.ProductList
            //.Select(p => p.Category)
            //.Distinct();


            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result= setA.Except(setB);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q15
            //var dict = Source.ProductList
            //.ToDictionary(p => p.ProductID);

            //var product = dict[18];
            //Console.WriteLine(product.ProductName);
            #endregion

            #region Q16
            //var result = Source.ProductList.Any(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Q17
            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);
            #endregion

            #region Q18
            var result = Enumerable.Range(1, 10).Select(N => N * 7);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Q19
            //var result = Enumerable.Range(1, 30).Where(N => N % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q20

            #endregion

            #region Q21

            #endregion



        }
    }
}
