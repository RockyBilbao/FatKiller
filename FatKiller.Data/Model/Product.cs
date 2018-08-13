using FatKiller.Data.Model.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatKiller.Data.Model
{
    public class Product : EntityBase
    {
        public Product()
        {
            DailyFoodDiaryProduct = new HashSet<DailyFoodDiaryProduct>();
        }

        [Key]
        [Required]
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public double ProductPrice { get; set; }

        [ForeignKey("Macronutrients")]
        public Guid? MacronutrientsId { get; set; }

        public virtual Macronutrients Macronutrients { get; set; }

        public virtual ICollection<DailyFoodDiaryProduct> DailyFoodDiaryProduct { get; set; }
    }

    public enum ProductCategory
    {
        Meat = 0,
        Vegetables = 1
    }
}
