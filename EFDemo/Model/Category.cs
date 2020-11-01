using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    [Table("Categories")]
    public partial class Category
    {
        public Category() => Products = new HashSet<Product>();
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
       
    }
}
