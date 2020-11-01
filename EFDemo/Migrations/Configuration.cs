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
            context.Products.Add(new Product { Name = "ASP.NET MVC �ӷ~���ζ}�o���", Price = 850, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Entity Framework ��Ⱥ�n", Price = 800, Category_Id = 1 });
            context.Products.Add(new Product { Name = "HTML 5�q�s�}�l", Price = 550, Category_Id = 1 });
            context.Products.Add(new Product { Name = "HTML 5��������", Price = 1000, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Entity Framework �P LINQ �}�o���", Price = 590, Category_Id = 1 });
            context.Products.Add(new Product { Name = "ASP.net �ӷ~�Ÿ�Ʈw�����}�o���", Price = 650, Category_Id = 1 });
            context.Products.Add(new Product { Name = "Visual C#��n��R", Price = 520, Category_Id = 1 });
            context.Products.Add(new Product { Name = "3U�u�~�ξ���", Price = 4000, Category_Id = 2 });
            context.Products.Add(new Product { Name = "CUP������ MITX", Price = 950, Category_Id = 2 });
            context.Products.Add(new Product { Name = "�|���ަh�X�@CPU����", Price = 980, Category_Id = 2 });
            context.Products.Add(new Product { Name = "PC RS 232 �X�R�d", Price = 1020, Category_Id = 2 });
            context.Products.Add(new Product { Name = "ASUC ������	", Price = 3600, Category_Id = 2 });
            context.Products.Add(new Product { Name = "8 PORT USB�R�q��", Price = 1620, Category_Id = 2 });
            context.Products.Add(new Product { Name = "8 PORT USB�R�q��", Price = 1620, Category_Id = 2 });
            context.Products.Add(new Product { Name = "�T��2400�̶ǿ�u", Price = 2500, Category_Id = 3 });
            context.Products.Add(new Product { Name = "��ʹq���W���� 85000mAh", Price = 500, Category_Id = 3 });
            context.Products.Add(new Product { Name = "��ʹq��USB���l�q��", Price = 1800, Category_Id = 3 });
            context.Products.Add(new Product { Name = "���Shap���q��", Price = 1600, Category_Id = 3 });
            context.Products.Add(new Product { Name = "AC��USB�R�q��", Price = 280, Category_Id = 3 });
            context.Products.Add(new Product { Name = "USB�_�j4�T����", Price = 850, Category_Id = 4 });
            context.Products.Add(new Product { Name = "LED�O B-LED	", Price = 250, Category_Id = 4 });
            context.Products.Add(new Product { Name = "USB 3.0 �@�ɶǿ�u", Price = 1500, Category_Id = 4 });
            context.Products.Add(new Product { Name = "USB 3.0 18 HUB", Price = 1450, Category_Id = 4 });
            context.Products.Add(new Product { Name = "7 Port USB�R�q��", Price = 2250, Category_Id = 4 });


            context.Categorys.Add(new Category { Id = 1, Name = "Book" });
            context.Categorys.Add(new Category { Id = 2, Name = "PC" });
            context.Categorys.Add(new Category { Id = 3, Name = "Mobile" });
            context.Categorys.Add(new Category { Id = 4, Name = "USB" });
            context.SaveChanges();
        }
    }
}
