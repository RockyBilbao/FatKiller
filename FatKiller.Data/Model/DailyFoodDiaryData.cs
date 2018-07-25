using FatKiller.Data.Model.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatKiller.Data.Model
{
    public class DailyFoodDiaryData : EntityBase
    {
        public DailyFoodDiaryData()
        {
            DailyFoodDiary = new HashSet<DailyFoodDiary>();
        }

        [Key]
        [Required]
        public Guid DailyFoodDiaryDataId { get; set; }

        public DateTime Day { get; set; } //TODO zmiania nazwy

        public virtual ICollection<DailyFoodDiary> DailyFoodDiary { get; set; }
    }

}
