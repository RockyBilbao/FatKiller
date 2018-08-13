using FatKiller.Data.Model.ModelsBase;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatKiller.Data.Model
{
    public class DailyFoodDiaryProduct : EntityBase
    {
        [Key]
        [Required]
        public Guid DailyFoodDiaryProductId { get; set; }

        [ForeignKey("Product")]
        public Guid? ProductId { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey("DailyFoodDiary")]
        public Guid? DailyFoodDiaryId { get; set; }

        public virtual DailyFoodDiary DailyFoodDiary { get; set; }
    }
}
