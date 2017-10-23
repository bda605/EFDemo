using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Model;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Collections;
namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //KTStoreModel model = new KTStoreModel();
            //int c = model.Product.Count();
            //Console.WriteLine(c);
            //Console.ReadLine();
            //using (var context = new KTStoreModel()) 
            //{
                //IEnumerable<Product> product =
                //  from products in context.Product
                //  select products;
                //string sql = product.ToString();
                //Console.WriteLine("{0}", sql);
                //Console.ReadLine();
                //IEnumerable<Product> products =
                //    from product in context.Products
                //    select product;
                // string sql = products.ToString();
                //Console.WriteLine("{0}", sql);
   
                //foreach (Product p in products)
                //{
                //    Console.WriteLine(p.Name);
                //}
                //Console.ReadLine();

                //Product fproduct = context.Products.First();
                //fproduct.Price = 699;
                //Console.WriteLine("{0} {1}\t 價格:{2}", fproduct.Id, fproduct.Name, fproduct.Price);
                //context.SaveChanges();

                //context.Entry(fproduct).Reload();
                //fproduct = context.Products.First();
                //Console.WriteLine("{0} {1}\t 價格:{2}", fproduct.Id, fproduct.Name, fproduct.Price);
                //context.Database.Log = Console.Write;
                //IEnumerable<Product> products =
                //               from product in context.Products
                //               select product;
                //context.Database.Log = Console.Write;
                //IEnumerable<Product> products =
                //    from product in context.Products
                //    select product;
                //foreach (Product p in products) 
                //{
                
                //}


                //ObjectContext objectContext =
                //    (context as IObjectContextAdapter).ObjectContext;
                //ObjectSet<Product> products =
                //   objectContext.CreateObjectSet<Product>();
                //var oq = (ObjectQuery)products.Where
                //    (p => p.Price > 1000 && p.Price < 2000);
                //Console.WriteLine(oq.ToTraceString());

                //foreach (Product product in oq) 
                //{
                //    Console.WriteLine(product.Name);
                //}
                //var ps = context.Products.Where(
                //    p => p.Price > 1000 && p.Price < 2000);
                //Console.WriteLine(ps.ToString());
                //foreach (Product product in ps) 
                //{
                //    Console.WriteLine(product.Name);
                //}
                //Console.ReadLine();

                //Product p1 = new Product
                //{
                //    Id=24,
                //    Name="book1",
                //    Category = "Book",
                //    Price =550
                //};
                //Product p2 = new Product
                //{
                //    Id = 25,
                //    Name = "book2",
                //    Category = "Book",
                //    Price = 450
                //};

                //DbSet<Product> products = context.Products;
                //products.Add(p1);
                //products.Add(p2);
                //context.SaveChanges();
                //foreach (Product p in products) 
                //{
                //    Console.WriteLine(p.Name);
                //}

                //var local = context.Products.Local;
                //Console.WriteLine("Local:{0}", local.Count());

                //foreach (Product p in context.Products) 
                //{
                   
                //}
                //Console.WriteLine("Query-Local:{0}", local.Count());

                //context.Products.Add(new Product { 
                //  Id = 1001,
                //  Name = "Android III",
                //  Price = 1000
                //});
                //Console.WriteLine("Query-Local:{0}", local.Count());
                //Console.ReadLine();

                //context.Database.Log = Console.WriteLine;
                //var products = context.Products.Where(p => p.Price > 1000);
                //Product firstProduct = products.First();

                //Console.WriteLine("\n第一筆商品資料集:{0}:\n", firstProduct.Name);

                //Console.WriteLine("\n所有商品資料清單:\n");
                //foreach (var product in products) 
                //{
                //    Console.WriteLine(product.Name);
                //}
                //Console.Read();
                // }

            using (var context = new KTStoreModel()) 
            {
                //var products = from product in context.Products
                //               select product;
                //foreach (Product product in products) 
                //{
                //    Console.WriteLine(product.Name);
                //}
                //Console.ReadKey();

                //IQueryable<Product> products =
                //    from product in context.Products
                //    select product;
                //foreach (Product product in products) 
                //{
                //    Console.WriteLine("分類:{0}\t{1}\t{2} 價格:{2}\t",
                //        product.Category,
                //        product.Id,
                //        product.Name,
                //        product.Price);
                //}

                //var products = from product in context.Products
                //               select new { product.Name,product.Price};
                //foreach (var product in products) 
                //{
                //    Console.WriteLine("價格:{0} \t{1}", product.Price, product.Name);
                //}

                //var products =
                //    from product in context.Products
                //    select new
                //    {
                //        ProductName = product.Name,
                //        Price = product.Price,
                //        SPrice = product.Price * 0.8
                //    };
                //foreach (var product in products) 
                //{
                //    Console.WriteLine("價格:{0} \t 特價:{1} \t 商品:{2}",
                //        product.Price,
                //        product.SPrice,
                //        product.ProductName);
                //}
                //IEnumerable<SProduct> products =
                //    from product in context.Products.ToList()
                //    select ToSProduct(product);
                //foreach (var product in products) 
                //{
                //    Console.WriteLine("{0}\t訂價:{1}\t特價:{2}\t:{3}",
                //        product.PId, product.Price,
                //        product.SPrice, product.CName);
                //}
                //string[] weekMonth = { "JANUARY,FEBRUARY,MARCH,APRIL,MAY,JUNE,JULY,AUGUST,SEPTEMBER,OCTOBER,NOVERMBER,DECEMBER,"
                //                     + "Monday,Tusday,Wednesday,Thursday,Friday,Saturday,Sunday"};
                //IEnumerable<string> enumWeekMonth = from wm in weekMonth
                //                                    from daywm in wm.Split(',')
                //                                    select daywm.Substring(0, 3);

                //string weekDayOuput = "一星期七天與一年十二個月英文全名:\n";
                //foreach (string dayweekmonth in weekMonth) 
                //{
                //    weekDayOuput += dayweekmonth + "\n";
                //}
                //Console.WriteLine(weekDayOuput);

                //weekDayOuput = "一星期七天與一年十二個月英文縮寫:\n";
                //foreach (string dayweekmonth in enumWeekMonth) 
                //{
                //    weekDayOuput += dayweekmonth + "\n";
                //}
                //Console.WriteLine(weekDayOuput);
                //Console.ReadLine();

                //var products = from category in context.Categorys
                //               from product in context.Products
                //               select new
                //               {
                //                   CategoryName = category.Name,
                //                   ProductName = product.Name
                //               };
                //foreach (var p in products)
                //    Console.WriteLine("分類:{0}\t{1}", p.CategoryName, p.ProductName);


                //var products = context.Categorys.SelectMany(
                //                                c => c.Product.Select(
                //                                    p => new
                //                                    {
                //                                        ProductName = p.Name,
                //                                        CategoryName = c.Name
                //                                    }));
                //foreach (var p in products)
                //    Console.WriteLine("分類:{0}\t{1}", p.CategoryName, p.ProductName);

                //var products = from category in context.Categorys
                //               where category.Id == 1
                //               from product in category.Product
                //               select product;

                //var products = context.Categorys
                //    .Where(c => c.Id == 1).SelectMany(c => c.Product).
                //    Select(p => p);
               
                //Console.WriteLine("圖書清單\n");
                //foreach (var p in products) 
                //{
                //    Console.WriteLine("價格:{0}\t{1}", p.Price, p.Name);
                //}

                //IEnumerable<Product> products =
                //    from p in context.Products
                //    where p.Price >= 800 && p.Price <= 1600
                //    select p;

                //IEnumerable<Product> products = context.Products.Where(
                //    product => product.Price >= 800 && product.Price <= 1600);
                //Console.WriteLine("價格介於800-1600元商品:\n");
                //foreach (var product in products)
                //    Console.WriteLine("價格:{0}\t{1}:", product.Price, product.Name);
                //int[] numberQuery = { 123, 456, 789, 100, 365, 7, 24 };
                //IEnumerable<int> enumNumbers =
                //    from number in numberQuery
                //    where number <= 300 && number >= 100
                //    select number;

                //string source = "原始數字:";
                //foreach (int number in numberQuery)
                //{
                //    source += number + ",";
                //}
                //Console.WriteLine(source);
                //string result = "查詢結果(100-300間的數字):";
                //foreach (int number in enumNumbers) 
                //{
                //    result += number + ",";
                //}
                //Console.WriteLine(result);
                //enumNumbers =
                //    from number in numberQuery
                //    where CheckEven(number)
                //    select number;
                //foreach (int number in enumNumbers)
                //    result += number + ",";

                //Console.WriteLine(result);
                //Console.ReadLine();

                //IEnumerable<Product> products =
                //    from product in context.Products.ToList()
                //    where CheckPrice(product.Price)
                //    select product;
                //Console.WriteLine("價格介於800-1600商品");
                //foreach (var product in products)
                //    Console.WriteLine("價格:{0}\t{1}", product.Price, product.Name);


                //var products =
                //    from product in context.Products
                //    orderby product.Price
                //    select product;
                //foreach (var product in products)
                //    Console.WriteLine("價格：\t{2}\t{0}\t{1}", product.Id, product.Name, product.Price);
                //Console.ReadLine();

                //var products = context.Products.OrderBy(p => p.Price).ToList();
                //products.Reverse();
                //foreach (var product in products)
                //    Console.WriteLine("價格：{0}\t{1}", product.Price, product.Name);

               // List<int> monthList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                //IEnumerable<IGrouping<int, int>> query =
                //    from month in monthList
                //    group month by checkMonth(month);

                //IEnumerable<IGrouping<int, int>> query =
                //    from month in monthList
                //    group month by checkMonth(month) into o
                //    orderby o.Key
                //    select o;
                //IEnumerable<IGrouping<int, int>> query =
                //    monthList.GroupBy(month => checkMonth(month))
                //    .Select(g => g).OrderBy(g => g.Key);
                //foreach (var group in query)
                //{
                //    Console.WriteLine(group.Key > 30 ? "\n大月:" : "小月");
                //    foreach (int i in group)
                //    {
                //        Console.Write(i + "-" + group.Key.ToString() + " ");
                //    }
                //}
                //IEnumerable<IGrouping<string, Product>> groups =
                //    from product in context.Products
                //    group product by product.Category.Name;
                //foreach (IGrouping<string, Product> group in groups) 
                //{
                //    Console.WriteLine(group.Key);
                //    foreach (Product product in group) 
                //    {
                //        Console.WriteLine("\t{0}\t價格{1}", product.Name, product.Price);
                //    }
                //}

                //IEnumerable<IGrouping<int, Product>> groups =
                //    from product in context.Products.ToList()
                //    group product by CheckPrice(product.Price);

                //foreach (IGrouping<int, Product> group in groups) 
                //{
                //    string message = "";
                //    if (group.Key == 3000)
                //        message = "\n高價 > 2000 \n";
                //    else if (group.Key == 2000)
                //        message = "\n中價 1001-2000\n";
                //    else
                //        message = "\n低價 < 1000\n";

                //    Console.WriteLine(message);
                //    foreach (Product product in group) 
                //    {
                //        Console.WriteLine(" 價格:{1}\t{0}", product.Name, product.Price);
                //    }
                //}

         

                //IEnumerable<IGrouping<int, Product>> groups =
                //       from product in context.Products.ToList()
                //       group product by CheckPrice(product.Price);
                 
                Console.ReadLine();
            }


          
              
        }
        static int checkMonth(int month) 
        {
            int resultDays;
            resultDays = DateTime.DaysInMonth(2008, month);
            return resultDays;
        }
        //static bool CheckPrice(int? price) 
        //{
        //    bool b = price > 800 && price <= 1600;
        //    return b;
        //}
        static int CheckPrice(int Price) 
        {
            if (Price > 2000)
                return 3000;
            else if (Price >= 1000 && Price <= 2000)
                return 2000;
            else
                return 1000;
        }
        private static bool CheckEven(int nvalue) 
        {
            bool returnValue = (nvalue % 2 == 0);
            return returnValue;
        }

        static SProduct ToSProduct(Product product) 
        {
                    return new SProduct()
                    {
                        PId = product.Id.ToString().PadLeft(4,'0'),
                        CName = product.Category + "__" + product.Name,
                        Price = product.Price,
                        SPrice = product.Price * 0.8
                    };
        }
    }
    class SProduct 
    {
        public string PId { get; set; }
        public string CName { get; set; }

        public int Price { get; set; }

        public double SPrice { get; set; }

    }
}
