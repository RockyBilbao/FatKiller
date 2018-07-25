using FatKiller.Data.Model.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatKiller.Data.Model
{
    public class Macronutrients : EntityBase
    {
        public Macronutrients()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        public Guid MacronutrientsId { get; set; }

        [Required]
        public double Carbohydrates { get; set; }

        [Required]
        public double Protein { get; set; }

        [Required]
        public double Fat { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
