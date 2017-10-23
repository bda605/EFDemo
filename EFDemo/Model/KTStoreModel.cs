using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EFDemo.Model
{
    public class KTStoreModel:DbContext
    {

        public KTStoreModel() : base("name=KTStoreModelConn") 
        {
          
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
