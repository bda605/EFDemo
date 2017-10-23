using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.Model
{
   
    public class Product
    {
        //[Key]
        //public int PId { get; set; }
        //[Required]
        //[Column("ProductName")]
        //[MaxLength(50, ErrorMessage = ""), MinLength(2)]
        //[Index("ProductNameIndex", 2, IsUnique = true)]
        //public string Name { get; set; }

        //[Column("ListPrice",TypeName="Money")]
        //public int Price { get; set; }
       
        //public string Category { get; set; }

        //[NotMapped]       
        //public decimal SPrice { get; set; }

        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime Created { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

       // public int Quantity { get; set; }
        public int Category_Id { get; set; }

        [ForeignKey("Category_Id")]
        public virtual Category Category { get; set; }


    }
}
