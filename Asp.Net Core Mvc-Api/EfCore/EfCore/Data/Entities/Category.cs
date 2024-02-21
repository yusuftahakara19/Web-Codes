using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore.Data.Entities
{
    public class Category 
    {
        [Column("category_id")]
        public int Id { get; set; }

        [Required]
        [Column("category_name",TypeName ="nvarchar(100)")]
        public string Name{ get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

    }
}
