using EFDemo.Model;

namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.Model.KTStoreModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFDemo.Model.KTStoreModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.Add(new Product { Name = "ASP.NET MVC 商業應用開發實務", Price = 850, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Entity Framework 實務精要", Price = 800, Category_Id = 1 });
            context.Products.Add(new Product { Name = "HTML 5從零開始", Price = 550, Category_Id = 1 });
            context.Products.Add(new Product { Name = "HTML 5完美風暴", Price = 1000, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Entity Framework 與 LINQ 開發實戰", Price = 590, Category_Id = 1 });
            context.Products.Add(new Product { Name = "ASP.net 商業級資料庫網站開發實務", Price = 650, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Visual C#精要剖析", Price = 520, Category_Id = 1 });
            context.Products.Add(new Product { Name = "3U工業用機殼", Price = 4000, Category_Id = 2 });
            context.Products.Add(new Product { Name = "CUP散熱器 MITX", Price = 950, Category_Id = 2 });
            context.Products.Add(new Product { Name = "四熱管多合一CPU風扇", Price = 980, Category_Id = 2 });
            context.Products.Add(new Product { Name = "PC RS 232 擴充卡", Price = 1020, Category_Id = 2 });
            context.Products.Add(new Product { Name = "ASUC 變壓器	", Price = 3600, Category_Id = 2 });
            context.Products.Add(new Product { Name = "8 PORT USB充電器", Price = 1620, Category_Id = 2 });
            context.Products.Add(new Product { Name = "8 PORT USB充電器", Price = 1620, Category_Id = 2 });
            context.Products.Add(new Product { Name = "鋁殼2400米傳輸線", Price = 2500, Category_Id = 3 });
            context.Products.Add(new Product { Name = "行動電源超薄型 85000mAh", Price = 500, Category_Id = 3 });
            context.Products.Add(new Product { Name = "行動電源USB離子電芯", Price = 1800, Category_Id = 3 });
            context.Products.Add(new Product { Name = "手機Shap離電池", Price = 1600, Category_Id = 3 });
            context.Products.Add(new Product { Name = "AC轉USB充電器", Price = 280, Category_Id = 3 });
            context.Products.Add(new Product { Name = "USB復古4吋風扇", Price = 850, Category_Id = 4 });
            context.Products.Add(new Product { Name = "LED燈 B-LED	", Price = 250, Category_Id = 4 });
            context.Products.Add(new Product { Name = "USB 3.0 共享傳輸線", Price = 1500, Category_Id = 4 });
            context.Products.Add(new Product { Name = "USB 3.0 18 HUB", Price = 1450, Category_Id = 4 });
            context.Products.Add(new Product { Name = "7 Port USB充電器", Price = 2250, Category_Id = 4 });


            context.Categorys.Add(new Category { Id = 1, Name = "Book" });
            context.Categorys.Add(new Category { Id = 2, Name = "PC" });
            context.Categorys.Add(new Category { Id = 3, Name = "Mobile" });
            context.Categorys.Add(new Category { Id = 4, Name = "USB" });
            context.SaveChanges();
        }
    }
}
