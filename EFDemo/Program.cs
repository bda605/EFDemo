using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Program
    {
        private static void Main(string[] args)
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

            //using (var context = new KTStoreModel())
            //{
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

            //IEnumerable<IGrouping<string, Product>> groups =
            //    from product in context.Products
            //    group product by product.Category.Name into cgroup
            //    orderby cgroup.Key descending
            //    select cgroup;
            //foreach (IGrouping<string, Product> group in groups)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (Product product in group)
            //        Console.WriteLine("\t{0}\t價格:{1}", product.Name, product.Price);
            //}

            //SPList<Product> products = new SPList<Product> {
            //     new Product()
            //     {Id=1000,Name ="BOOKX01",Price=900,Category ="Book"},
            //        new Product()
            //     {Id=1001,Name ="BOOKX02",Price=700,Category ="Book"},
            //        new Product()
            //     {Id=1002,Name ="BOOKX03",Price=800,Category ="Book"},
            //};
            //Console.WriteLine(products.Average(p => p.Price));
            //Console.WriteLine(products.AsEnumerable().Average(p => p.Price));

            //List<string> weekDay = new List<string> { "Monday", "Tuesday", "Wendnesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //string[] weekDayArray = weekDay.ToArray();
            //for (int i = 0; i < weekDayArray.Length; i++)
            //{
            //    Console.Write("{0} ", weekDayArray[i]);
            //}
            //Console.WriteLine();

            //List<string> weekDayList = weekDayArray.ToList();
            //foreach (string day in weekDayList)
            //{
            //    Console.Write("{0} ", day);
            //}
            //IQueryable<Product> query = from product in context.Products
            //                           select product;

            //var list = from product in query.ToList()
            //           where checkPrice(product.Price)
            //           select product;
            //Console.WriteLine("定價超過1500的品項數:{0}", list.Count());

            //string[] list = (from product in context.Products
            //                 select product.Name).ToArray();
            //for (int i = 0; i < list.Length; i++)
            //    Console.WriteLine(list[i]);

            //List<string> listBooks = new List<string> {
            //   "ASP.NET MVC入門",
            //   "React 實務",
            //   "Entity Framework實務精要",
            //   "前端開發完全入門",
            //   "ASP.NET 專業開發"
            //};
            //int indexValue = 0;
            //Dictionary<string, string> booksDictionary =
            //     listBooks.ToDictionary(
            //     keyValue => "book-" +
            //         (indexValue++).ToString()
            //     );
            //foreach (KeyValuePair<string, string> kvp
            //    in booksDictionary)
            //{
            //    Console.WriteLine("{0}\t{1}", kvp.Key, kvp.Value);
            //}

            //IQueryable<Product> products =
            //    from product in context.Products
            //    select product;
            //Dictionary<string, Product> directory =
            //    products.ToDictionary(
            //    key => key.Category_Id + "_" + key.Id);
            //foreach (KeyValuePair<string, Product> key in directory)
            //{
            //    Console.WriteLine("{0}\t{1}", key.Key, key.Value.Name);
            //}

            //List<string> listBooks = new List<string> {
            //   "ASP.NET MVC入門",
            //   "React 實務",
            //   "Entity Framework實務精要",
            //   "前端開發完全入門",
            //   "ASP.NET 專業開發"
            //};

            //int i = 0;
            //ILookup<string, string> lookup =
            //    listBooks.ToLookup(key => "book");
            //foreach (IGrouping<string, string> igp in lookup)
            //{
            //    Console.WriteLine("{0}", igp.Key);
            //    foreach (string str in igp)
            //        Console.WriteLine(" " + str);
            //}

            //IQueryable<Product> products =
            //    from product in context.Products
            //    select product;
            //ILookup<string, Product> look =
            //    products.ToLookup(
            //    key => key.Category_Id.ToString()
            //    );
            //foreach (IGrouping<string, Product> group in look)
            //{
            //    Console.WriteLine("\n{0}", group.Key);
            //    foreach (Product product in group)
            //    {
            //        Console.WriteLine(" {0}\t{1}", product.Id,
            //            product.Name);
            //    }
            //}

            // Console.Read();
            //}

            //var t = RunAsyncQuery();
            //Console.WriteLine("資料開始截取...");

            //Task<List<Product>> ps = RunAsyncQueryP();
            //Console.WriteLine("資料開始截取..\n");
            //List<Product> products = ps.Result;
            //foreach (Product p in products)
            //    Console.WriteLine("{0}\t{1}", p.Id, p.Name);
            //Console.ReadKey();

            //var cbooks =
            //    from c in categories
            //    join b in books on
            //    c.Id equals b.CategoryId
            //    select new {
            //        BookCategory = c.Name,
            //        BookTitle = b.Name
            //    };
            //foreach (var book in cbooks)
            //    Console.WriteLine("書籍分類:{0}\t書名:{1}", book.BookCategory.PadLeft(8), book.BookTitle);

            //using (var context = new KTStoreModel())
            //{
            //    //var products = from category in context.Categorys
            //    //               join product in context.Products on
            //    //               category.Id equals product.Category_Id
            //    //               select new
            //    //               {
            //    //                   Category = category.Name,
            //    //                   Product = product.Name,
            //    //                   Price = product.Price
            //    //               };
            //    //foreach (var cp in products)
            //    //    Console.WriteLine("分類:{0}\t{1}\t價格:{2}:", cp.Category, cp.Product, cp.Price);
            //    //int n = 1;
            //    //IEnumerable<IEnumerable<Product>> pgroup =
            //    //    from category in context.Categorys
            //    //    join product in context.Products on
            //    //    category.Id equals product.Category_Id
            //    //    into productgroup
            //    //    select productgroup;
            //    //foreach (var products in pgroup)
            //    //{
            //    //    Console.WriteLine("\n分類{0} 資料筆數:{1}\n", n, products.Count());
            //    //    foreach (var product in products)
            //    //        Console.WriteLine("\t{0}", product.Name);
            //    //    n++;
            //    //}

            //    IEnumerable<GCProduct> pgroup =
            //        from category in context.Categorys
            //        join product in context.Products on
            //        category.Id equals product.Category_Id
            //        into productgroup
            //        select new GCProduct()
            //        {
            //           CategoryName = category.Name,
            //           Products = productgroup
            //        };
            //    foreach (var category in pgroup)
            //    {
            //        Console.WriteLine("\n{0}:{1}\n", category.CategoryName, category.Products.Count());
            //        foreach (var product in category.Products)
            //        {
            //            Console.WriteLine("{0}", product.Name);
            //        }
            //    }
            //}

            //新版
            using (var context = new KTStoreModel())
            {
                //IEnumerable<Product> products = from product in context.Products
                //                                select product;
                //Console.WriteLine(products.ToString());
                //foreach (var product in products)
                //{
                //    Console.WriteLine(product.Name);
                //}

                //Product fprodcut = context.Products.First();
                //fprodcut.Price = 599;
                //Console.WriteLine("{0} {1}\t價格:{2}",fprodcut.Id,fprodcut.Name,fprodcut.Price);
                //context.SaveChanges();

                //context.Entry(fprodcut).Reload();
                //fprodcut = context.Products.First();

                //Console.WriteLine("{0} {1}\t價格:{2}",fprodcut.Id,fprodcut.Name,fprodcut.Price);

                //ObjectContext objectContext = (context as IObjectContextAdapter).ObjectContext;
                //ObjectSet<Product> products =
                //    objectContext.CreateObjectSet<Product>();
                //var oq = (ObjectQuery) products.Where(p => p.Price > 1000 && p.Price < 2000);
                //Console.WriteLine(oq.ToString());
                //foreach (Product product in oq)
                //{
                //    Console.WriteLine(product.Name);
                //}

                //var ps = context.Products.Where(p => p.Price > 1000 && p.Price < 2000);
                //Console.WriteLine(ps.ToString());
                //foreach (var p in ps)
                //{
                //    Console.WriteLine(p.Name);
                //}

                //var local = context.Products.Local;
                //Console.WriteLine($"local:{local.Count}");
                //foreach (Product p in context.Products)
                //{
                //}

                //Console.WriteLine($"Query-Local:{local.Count()}");

                //context.Products.Add(new Product
                //{
                //    Id = 1001,
                //    Name = "Android III",
                //    Price = 1000
                //});
                //Console.WriteLine($"Add-Local:{local.Count()}");

                //context.Database.Log = Console.WriteLine;
                //var products = context.Products.Where(p => p.Price > 1000);
                //Product firstProduct = products.First();
                //Console.WriteLine($"first Data:{firstProduct.Name}");
                //Console.WriteLine($"所有商品清單");
                //foreach (var product in products)
                //{
                //    Console.WriteLine(product.Name);
                //}

                //var products = context.Products.Select(p => p);
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p.Name);
                //}

                //IQueryable<Product> products = from product in context.Products
                //    select product;
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p);
                //}

                //var products = from product in context.Products
                //    select new
                //    {
                //        product.Name,product.Price
                //    };

                //foreach (var p in products)
                //{
                //    Console.WriteLine($"Price:{p.Price} \t {p.Name}");
                //}
                //var products = from p in context.Products
                //    select new
                //    {
                //        ProductName = p.Name,
                //        Price = p.Price,
                //        SPrice = p.Price * 0.8
                //    };
                //foreach (var p in products)
                //{
                //    Console.WriteLine($"Price:{p.Price}\t SPrice:{p.SPrice} \t Name:{p.ProductName}");
                //}

                //IEnumerable<SProduct> products = from p in context.Products.ToList()
                //                                 select new SProduct()
                //                                 {
                //                                     PId = p.Id.ToString().PadLeft(4, '0'),
                //                                     Price = p.Price,
                //                                     SPrice = p.Price * 0.8
                //                                 };
                //foreach (var p in products)
                //{
                //    Console.WriteLine($"Id:{p.PId} \t Price:{p.Price} \t SPrice:{p.SPrice}");
                //}

                //var products = from category in context.Categorys
                //    from product in category.Product
                //    select new
                //    {
                //         CategoryName = category.Name,
                //         ProductName = product.Name
                //    };
                //var products = context.Categorys.SelectMany(
                //    c => c.Product.Select(
                //        p => new
                //        {
                //            ProductName = p.Name,
                //            CategoryName = c.Name
                //        }));
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p.CategoryName + "\t" + p.ProductName);
                //}

                //var products = from category in context.Categorys
                //    where category.Id == 1
                //    from product in context.Products
                //    select product;

                //foreach (var p in products)
                //{
                //    Console.WriteLine($"Price:{p.Price}\t ProductName:{p.Name}");
                //}

                //IEnumerable<Product> products = from p in context.Products
                //    where p.Price >= 800 && p.Price <= 1600
                //    select p;

                // IEnumerable<Product> products = context.Products.Where(p => p.Price > 800 && p.Price <= 1600);

                //IEnumerable<IGrouping<string, Product>> groups = from p in context.Products
                //    group p by p.Category.Name;
                //foreach (IGrouping<string,Product> group in groups )
                //{
                //    Console.WriteLine(group.Key);
                //    foreach (var product in group)
                //    {
                //        Console.WriteLine("ProductName:{0}\t Price:{1}",product.Name,product.Price);
                //    }
                //}

                //IEnumerable<IGrouping<int, Product>> groups =
                //    from p in context.Products.ToList()
                //    group p by CheckPrice(p.Price);
                //foreach (IGrouping<int,Product> group in groups)
                //{
                //    string message = "";
                //    if (group.Key ==3000)
                //    {
                //        message = "\t高價 > 2000\n";
                //    }else if (group.Key == 2000)
                //    {
                //        message = "\n中價 1001-2000\n";
                //    }
                //    else
                //    {
                //        message = "\n低價 < 1000 \n";
                //    }

                //    Console.WriteLine(message);

                //    foreach (Product p in group)
                //    {
                //        Console.WriteLine($"價格:{p.Price}\t{p.Name}");
                //    }
                //}

                //List<string> numList = new List<string> { "First", "Two", "Three" };
                //string[] numListArr = numList.ToArray();
                //for (int i = 0; i < numListArr.Length; i++)
                //{
                //    Console.WriteLine($"{numListArr[i]}");
                //}

                //numList = numListArr.ToList();
                //foreach (var n in numList)
                //{
                //    Console.WriteLine($"{n}");
                //}

                //IQueryable<Product> list = from p in context.Products
                //    select p;
                //var tlist = from p in list.ToList()
                //            where checkPrice(p.Price)
                //            select p;
                //                     Console.WriteLine(tlist.Count());

                //string[] list = (from p in context.Products
                //                 select p.Name).ToArray();
                //for (int i = 0; i < list.Length; i++)
                //{
                //    Console.WriteLine(list[i]);
                //}

                //List<string> listBooks = new List<string>
                //{
                //    "A",
                //    "B",
                //    "C"
                //};

                //int indexValue = 0;
                //Dictionary<string, string> bookDic =
                //    listBooks.ToDictionary(
                //        KeyValue => "book-" +
                //                    (indexValue++).ToString());
                //foreach (KeyValuePair<string, string> kvp in bookDic)
                //{
                //    Console.WriteLine($"{kvp.Key} \t {kvp.Value}");
                //}

                //IQueryable<Product> products = from p in context.Products
                //    select p;
                //Dictionary<string, Product> dir =
                //    products.ToDictionary(
                //        key => key.Category_Id + "_" + key.Id);
                //foreach (KeyValuePair<string, Product> key in dir)
                //{
                //    Console.WriteLine($"{key.Key} \t {key.Value.Name}");
                //}

                //List<string> listBooks = new List<string>
                //{
                //    "A",
                //    "B",
                //    "C",
                //};
                //int i = 0;
                //ILookup<string, string> lookup = listBooks.ToLookup(key => "book");
                //foreach (IGrouping<string, string> igp in lookup)
                //{
                //    Console.WriteLine(igp.Key);
                //    foreach (string str in igp)
                //    {
                //        Console.WriteLine(str);
                //    }
                //}

                //IQueryable<Product> products = from p in context.Products
                //                               select p;

                //ILookup<int, Product> look = products.ToLookup(
                //    key => key.Category_Id
                //);
                //foreach (var group in look)
                //{
                //    Console.WriteLine(group.Key);
                //    foreach (var p in group)
                //    {
                //        Console.WriteLine($"{p.Id} \t {p.Name}");
                //    }
                //}

                //IEnumerable<IEnumerable<Product>>  cbooks = from c in context.Categorys
                //    join b in context.Products on
                //        c.Id equals b.Category_Id
                //        into bgroup
                //    select bgroup;

                //foreach (var cb in cbooks)
                //{
                //    foreach (var c in cb)
                //    {
                //        Console.WriteLine($"{c.Category_Id}\t{c.Name}");
                //    }
                //}

                //var cbooks = from c in context.Categorys
                //    join p in context.Products on
                //        c.Id equals p.Category_Id
                //        into bgroup
                //    select new
                //    {
                //        GCategory = c.Name,
                //        GBook = from b in bgroup
                //                select b
                //    };

                //foreach (var cb in cbooks)
                //{
                //    Console.WriteLine($"{cb.GCategory}");
                //    foreach (var c in cb.GBook)
                //    {
                //        Console.WriteLine($"{c.Category_Id}\t{c.Name}");
                //    }
                //}

                //var cbooks = context.Categorys.GroupJoin(
                //    context.Products,
                //    c => c.Id,
                //    p => p.Category_Id,
                //    (c, bgruop) => new
                //    {
                //        GCategory = c.Name,
                //        GBook = bgruop
                //    });
                //foreach (var cb in cbooks)
                //{
                //    Console.WriteLine($"{cb.GCategory}");
                //    foreach (var c in cb.GBook)
                //    {
                //        Console.WriteLine($"{c.Category_Id}\t{c.Name}");
                //    }
                //}

                //var products = from c in context.Categorys
                //    join p in context.Products
                //        on c.Id equals p.Category_Id
                //    select new
                //    {
                //        Category = c.Name,
                //        Product = p.Name,
                //        Price = p.Price
                //    };
                //foreach (var cp in products)
                //{
                //    Console.WriteLine($"分類:{cp.Category} \t {cp.Product} \t 價格:{cp.Price}");
                //}

                //int n = 1;
                //IEnumerable<IEnumerable<Product>> pgroup =
                //    from category in context.Categorys
                //    join Product in context.Products on
                //        category.Id equals Product.Category_Id
                //        into productgroup
                //    select productgroup;
                //foreach (var products in pgroup)
                //{
                //    Console.WriteLine($"\n class:" + n + " count:" + products.Count() +"\n");
                //    foreach (var product in products)
                //    {
                //        Console.WriteLine($"\t{product.Name}");
                //    }

                //    n++;
                //}

                //IEnumerable<GCProduct> pgroup =
                //    from category in context.Categorys
                //    join product in context.Products on
                //        category.Id equals product.Category_Id
                //        into productgroup
                //    select new GCProduct()
                //    {
                //        CategoryName = category.Name,
                //        Products = productgroup
                //    };

                //foreach (var category in pgroup)
                //{
                //    Console.WriteLine($"\n{category.CategoryName},{category.Products.Count()}");
                //    foreach (var product in category.Products)
                //    {
                //        Console.WriteLine($"{product.Name}");
                //    }
                //}

                //IQueryable<int> prices = from p in context.Products
                //                         select p.Price;
                //double average = prices.Average();
                //Console.WriteLine($"Price:{average}");
                //average = context.Products.Average(p => p.Price);
                //Console.WriteLine($"Price:{average}");
                //int count = context.Products.Count();
                //int max = context.Products.Max(p => p.Price);
                //int min = context.Products.Min(p => p.Price);
                //int sum = context.Products.Sum(p => p.Price);
                //Console.WriteLine($"商品數量:{count} \n 平均價格:{average} \n 最高價:{max} \n 最低價:{min} \n 總價值:{sum}");

                //List<string> list = new List<string>()
                //{
                //    "microsoft", "yahoo", "google"
                //};
                //string liststr = list.Aggregate((bword, aword) =>
                //    bword == "microsoft" ? "www." + bword + ".com" : bword + "\nwww." + aword + ".com");
                //Console.WriteLine(liststr);

                //var products = context.Products.ToList();
                //Product maxprice =
                //    products.Aggregate((bp, ap) => bp.Name.Contains("A") ? (bp.Price > ap.Price ? bp : ap) : ap);
                //Console.WriteLine($"包含A名稱最高價品項：{maxprice.Name}\t{maxprice.Price}");

                //char[] enumList1 = { 'a', 'b', 'c', 'd', 'e' };
                //char[] enumList2 = { 'd', 'e', 'g', 'h', 'i' };

                //Console.WriteLine("原始");
                //Program p = new Program();
                //p.ShowOutPut(enumList1);
                //p.ShowOutPut(enumList2);
                //IEnumerable<char> enumListSet = enumList1.Union(enumList2);

                //Console.WriteLine("\nunion");
                //p.ShowOutPut(enumListSet);

                //enumListSet = enumList1.Except(enumList2);
                //Console.WriteLine("\nExcept");
                //p.ShowOutPut(enumListSet);

                //enumListSet = enumList1.Intersect(enumList2);
                //Console.WriteLine("\nIntersect");
                //p.ShowOutPut(enumListSet);

                //IEnumerable<string> enumerable = Enumerable.Empty<string>();
                //int c = enumerable.Count();
                //Console.WriteLine(c);

                //IEnumerable<string> enumone = Enumerable.DefaultIfEmpty(enumerable);
                //c = enumone.Count();
                //Console.WriteLine(c);
                //foreach (var s in enumone)
                //{
                //    Console.WriteLine(string.IsNullOrEmpty(s));
                //}

                //IEnumerable<string> enumoned = Enumerable.DefaultIfEmpty(enumerable, "SUN");
                //Console.WriteLine(c);
                //foreach (var s in enumoned)
                //{
                //    Console.WriteLine(string.IsNullOrEmpty(s));
                //    Console.WriteLine(s);
                //}

                //Program p = new Program();
                //IEnumerable<int> enumNum = Enumerable.Range(1, 10);
                //p.ShowEnum("原始:", enumNum);

                //enumNum = Enumerable.Range(1, 10).Select(x => x * 2 + 1);
                //p.ShowEnum("奇數:",enumNum);

                //enumNum = Enumerable.Range(1, 10).Select(x => x * 2);
                //p.ShowEnum("偶數:",enumNum);

                //IEnumerable<string> enumerable = Enumerable.Repeat<string>("www.aaaaaaa.com.tw", 5);
                //foreach (var str in enumerable)
                //{
                //    Console.WriteLine(str);
                //}

                //IEnumerable<Product> rp = Enumerable.Repeat<Product>
                //(
                //    new Product() { Id = 100,Name = "Entity Framework",Category_Id = 1,Price = 800}
                //,12);

                //foreach (var p in rp)
                //{
                //    Console.WriteLine($"Id={p.Id}\tProductName={p.Name}\tPrice={p.Price}\tCategory={p.Category_Id}");
                //}

                //List<KangTing> strList = new List<KangTing>
                //{
                //    new KangTing{website = "www.kangting.tw",name = "康廷數位"},
                //    new KangTing{website = "www.kangting.tw",name = "康廷"},
                //    new KangTing{website = "www.kangting.tw",name = "康廷數位工作房"},
                //};
                //bool allCheck = strList.All(kanting => kanting.name == "康廷");

                //if (allCheck)
                //{
                //    Console.WriteLine("所有www.kangting.tw對應到康廷");
                //}
                //else
                //{
                //    Console.WriteLine("並非所有康廷對應");
                //}

                //List<checkString> strList2 = new List<checkString>
                //{
                //    new checkString{qName = "www"},
                //    new checkString{qName = "www.kangting"},
                //    new checkString{qName = "www.kangting.tw"},
                //};
                //allCheck = strList2.All(checkstring => checkstring.qName.StartsWith("www"));
                //if (allCheck)
                //{
                //    Console.WriteLine("所有wwww為字首");
                //}
                //else
                //{
                //    Console.WriteLine("並非WWW為字首");
                //}
                //IEnumerable<string> enumerable = Enumerable.Empty<string>();
                //bool anyBool = enumerable.Any();
                //if (anyBool==false)
                //{
                //    Console.WriteLine("null");
                //}
                //else
                //{
                //    Console.WriteLine("not null");
                //}

                //List<string> list = new List<string>
                //{
                //    "Mon","Tue","Wed","Thu","Fri","Sat","Sun"
                //};

                //Console.WriteLine("請輸入檢核字串:");
                //string s = Console.ReadLine();
                //bool b = list.Contains(s);
                //string result = "";
                //if (b == true)
                //{
                //    result = "包含";
                //}
                //else
                //{
                //    result = "不包含";
                //}

                //Console.WriteLine($"List Collection:{result},{s}");
                //Console.ReadKey();

                //IEnumerable<Product> products = context.Products.Where(p => p.Category_Id == 1);
                //bool b = products.All(p => p.Price <= 1000);
                //if (b)
                //{
                //    Console.WriteLine($"所有書籍定價1000以下");
                //}
                //else
                //{
                //    Console.WriteLine("所有書籍定價高於1000");
                //}

                //List<int> intList = new List<int>
                //{
                //    1,2,3,4,-5,6,7,8,9,0
                //};
                //IEnumerable<int> intListSkip = intList.Skip(5);
                //Console.WriteLine("原始內容:");
                //Console.Write(string.Join(",", intList));

                //Console.WriteLine("\nSkip 5個位子之後即和內容");
                //Console.Write(string.Join(",", intListSkip));

                //intListSkip = intList.TakeWhile(i => i < 6);
                //Console.WriteLine("\nWakeWhile i < 6");
                //Console.Write(string.Join(",", intListSkip));

                //intListSkip = intList.TakeWhile((i, idx) => i > idx);
                //Console.WriteLine("\n i > idx");
                //Console.Write(string.Join(",", intListSkip));

                //Console.Write("\n分頁資料筆數:");
                //int pcount = int.Parse(Console.ReadLine());
                //Console.Write("\n頁數:");
                //int pages = int.Parse(Console.ReadLine());
                //Console.WriteLine($"第{pages}分頁");
                //var p = (from product in context.Products
                //    orderby product.Id
                //    select product).Skip((pages - 1) * pcount).Take(pcount);
                //foreach (var product in p)
                //{
                //    Console.WriteLine(product.Id +"\t" + product.Name);
                //}

                //List<int> intList = new List<int>{1,2,3,4,-5,6,7,8,9,0};
                //int firstValue = intList.First();
                //Console.WriteLine($"first=" + firstValue);

                //firstValue = intList.FirstOrDefault();
                //Console.WriteLine($"firstOrDefault=" + firstValue);

                //IEnumerable<int> enumObject = Enumerable.Empty<int>();
                //firstValue = enumObject.FirstOrDefault();
                //Console.WriteLine($"enumObject.firstOrDefault="+firstValue);

                //List<int> intList = new List<int>{1,2,3,4,-5,6,7,8,9,0};
                //int firstValue = intList.First(intElement => intElement % 2 == 0);
                //Console.WriteLine(firstValue.ToString());

                //firstValue = intList.FirstOrDefault(intElement => intElement % 2 != 0);
                //Console.WriteLine(firstValue.ToString());

                //IEnumerable<int> enumObject = Enumerable.Empty<int>();
                //firstValue = enumObject.FirstOrDefault(intElement => intElement % 2 != 0);
                //Console.WriteLine(firstValue.ToString());

                //List<int> intList = new List<int> { 1, 2, 3, 4, -5, 6, 7, 8, 9, 0 };
                //int lastValue = intList.Last(intElement => intElement % 2 == 0);
                //Console.WriteLine(lastValue.ToString());

                //lastValue = intList.LastOrDefault(intElement => intElement % 2 != 0);
                //Console.WriteLine(lastValue.ToString());

                //IEnumerable<int> enumObject = Enumerable.Empty<int>();
                //lastValue = enumObject.LastOrDefault(intElement => intElement % 2 != 0);
                //Console.WriteLine(lastValue.ToString());

                //List<string> weekDays = new List<string>
                //{
                //    "Mon","Tue","Wed","Thu","Fri","Sat","Sun"
                //};

                //string elementAt = weekDays.ElementAt(4);
                //Console.WriteLine(elementAt);

                //List<string> kangtin = new List<string>{"www.kangting.com.tw"};
                //string elementSingle = kangtin.Single();
                //Console.WriteLine(elementSingle);

                //List<string> weekDays =new List<string>{"www.kangting.com.tw"};
                //foreach (var str in weekDays)
                //{
                //    Console.WriteLine(str);
                //}

                //string elementSingle = weekDays.SingleOrDefault(s => s.Substring(4, 8) == "kangting");
                //Console.WriteLine(elementSingle);

                //elementSingle = weekDays.SingleOrDefault(s => s.Substring(0, 3) == "wwk");
                //Console.WriteLine(elementSingle);
                IEnumerable<Category> categories =
                    from category in context.Categorys
                    select category;
                foreach (var c in categories)
                {
                    Console.WriteLine(c.Name);
                    foreach (var p in c.Products)
                    {
                        Console.WriteLine($"\t{p.Name}");
                    }
                }
            }

         
            // var t = RunAsyncQuery1();

            Console.ReadLine();
        }

        private static async Task RunAsyncQuery1()
        {
            using (var context = new KTStoreModel())
            {
                var product = await context.Products.FirstAsync();
                Console.WriteLine($"{product.Id}\t{product.Name}\t{product.Price}");

                var c = await context.Products.CountAsync();
                Console.WriteLine(c.ToString());

                var sum = await context.Products.Select(p => p.Price).SumAsync();
                Console.WriteLine(sum.ToString());

                var a = await context.Products.Select(p => p.Price).AverageAsync();
                Console.WriteLine(a.ToString());
            }
        }

        public void ShowEnum(string str, IEnumerable<int> enumNum)
        {
            Console.WriteLine(str);
            foreach (var i in enumNum)
            {
                Console.WriteLine(i + ",");
            }
        }

        public void ShowOutPut(IEnumerable<char> enumList)
        {
            string output = "";
            foreach (var c in enumList)
            {
                output += c + ",";
            }

            Console.WriteLine();
        }

        private class KangTing
        {
            public string website { get; set; }
            public string name { get; set; }
        }

        private class checkString
        {
            public string qName { get; set; }
        }

        public async Task RunAsyncQuery()
        {
            using (var context = new KTStoreModel())
            {
                var products = await context.Products.ToListAsync();
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }
            }
        }

        private static int CheckPrice(int pPrice)
        {
            if (pPrice > 2000)
            {
                return 3000;
            }
            else if (pPrice >= 1000 && pPrice <= 2000)
            {
                return 2000;
            }
            else
            {
                return 1000;
            }
        }

        public class GCProduct
        {
            public string CategoryName { get; set; }
            public IEnumerable<Product> Products { get; set; }
        }

        // static List<Category> categories = new List<Category>()
        //{
        //   new Category() {Name="ASP.NET",Id=001},
        //   new Category() {Name=".NET",Id=002},
        //   new Category() {Name="WEB",Id=003}
        //};
        // static List<Book> books = new List<Book>()
        // {
        //       new Book(){Name = "ASP.NET MVC開發實務",CategoryId=001},
        //       new Book(){Name = "ASP.NET MVC實務精要",CategoryId=001},
        //       new Book(){Name = "EF實務精要",CategoryId=002},
        //       new Book(){Name = "C#實務精要",CategoryId=002},
        //       new Book(){Name = "HTML5從零開始",CategoryId=003},
        //       new Book(){Name = "HTML5完美風暴",CategoryId=003},
        // };
        //static async Task RunAsyncQuery()
        //{
        //    using (var context = new KTStoreModel())
        //    {
        //        //var products = await context.Products.ToListAsync();
        //        //foreach (var product in products)
        //        //    Console.WriteLine(product.Name);
        //        await context.Products.ForEachAsync(product => {
        //            Console.WriteLine(product.Name);
        //        });
        //    }
        //}
        //static async Task<List<Product>> RunAsyncQueryP()
        //{
        //    using (var context = new KTStoreModel())
        //    {
        //        var products = await context.Products.ToListAsync();
        //        return products;
        //    }
        //}
        private static int checkMonth(int month)
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
        //static int CheckPrice(int Price)
        //{
        //    if (Price > 2000)
        //        return 3000;
        //    else if (Price >= 1000 && Price <= 2000)
        //        return 2000;
        //    else
        //        return 1000;
        //}
        private static bool checkPrice(int price)
        {
            if (price > 1500)
                return true;
            else
                return false;
        }

        private static bool CheckEven(int nvalue)
        {
            bool returnValue = (nvalue % 2 == 0);
            return returnValue;
        }

        private static SProduct ToSProduct(Product product)
        {
            return new SProduct()
            {
                PId = product.Id.ToString().PadLeft(4, '0'),
                CName = product.Category + "__" + product.Name,
                Price = product.Price,
                SPrice = product.Price * 0.8
            };
        }
    }

    internal class SProduct
    {
        public string PId { get; set; }
        public string CName { get; set; }

        public int Price { get; set; }

        public double SPrice { get; set; }
    }

    internal class Book
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    //class Category
    //{
    //    public string Name { get; set; }
    //    public int Id { get; set; }

    //}
    ////class Product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public int Price { get; set; }

    //    public string Category { get; set; }
    //}
    //class SPList<T> : List<T>
    //{
    //    public decimal Average(Func<T, decimal> s)
    //    {
    //        var list = (List<T>)this;
    //        decimal price = list.Average(s) * decimal.Parse("0.8");
    //        return price;
    //    }
    //}
}

//context.Products.Add(new Product { Name = "ASP.NET MVC 商業應用開發實務", Price = 850 , Category_Id = 1 });
//context.Products.Add(new Product { Name = "Entity Framework 實務精要", Price = 800	, Category_Id = 1 });
//context.Products.Add(new Product { Name = "HTML 5從零開始", Price = 550	, Category_Id = 1 });
//context.Products.Add(new Product { Name = "HTML 5完美風暴", Price = 1000, Category_Id = 1 });
//context.Products.Add(new Product { Name = "Entity Framework 與 LINQ 開發實戰", Price = 590	, Category_Id = 1 });
//context.Products.Add(new Product { Name = "ASP.net 商業級資料庫網站開發實務", Price = 650	, Category_Id = 1 });
//context.Products.Add(new Product { Name = "Visual C#精要剖析", Price = 520	, Category_Id = 1 });
//context.Products.Add(new Product { Name = "3U工業用機殼", Price = 4000, Category_Id = 2 });
//context.Products.Add(new Product { Name = "CUP散熱器 MITX", Price = 950	, Category_Id = 2 });
//context.Products.Add(new Product { Name = "四熱管多合一CPU風扇", Price = 980	, Category_Id = 2 });
//context.Products.Add(new Product { Name = "PC RS 232 擴充卡", Price = 1020, Category_Id = 2 });
//context.Products.Add(new Product { Name = "ASUC 變壓器	", Price = 3600, Category_Id = 2 });
//context.Products.Add(new Product { Name = "8 PORT USB充電器", Price = 1620, Category_Id = 2 });
//context.Products.Add(new Product { Name = "8 PORT USB充電器", Price = 1620, Category_Id = 2 });
//context.Products.Add(new Product { Name = "鋁殼2400米傳輸線", Price = 2500, Category_Id = 3 });
//context.Products.Add(new Product { Name = "行動電源超薄型 85000mAh", Price = 500	, Category_Id = 3 });
//context.Products.Add(new Product { Name = "行動電源USB離子電芯", Price = 1800, Category_Id = 3 });
//context.Products.Add(new Product { Name = "手機Shap離電池", Price = 1600, Category_Id = 3 });
//context.Products.Add(new Product { Name = "AC轉USB充電器", Price = 280	, Category_Id = 3 });
//context.Products.Add(new Product { Name = "USB復古4吋風扇", Price = 850	, Category_Id = 4 });
//context.Products.Add(new Product { Name = "LED燈 B-LED	", Price = 250	, Category_Id = 4 });
//context.Products.Add(new Product { Name = "USB 3.0 共享傳輸線", Price = 1500, Category_Id = 4 });
//context.Products.Add(new Product { Name = "USB 3.0 18 HUB", Price = 1450, Category_Id = 4 });
//context.Products.Add(new Product { Name = "7 Port USB充電器", Price = 2250, Category_Id = 4 });

//context.Categorys.Add(new Category { Id =  1, Name = "Book" });
//context.Categorys.Add(new Category { Id =  2, Name = "PC" });
//context.Categorys.Add(new Category { Id =  3, Name = "Mobile" });
//context.Categorys.Add(new Category { Id =  4, Name = "USB" });