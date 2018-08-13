using FatKiller.Data.Model.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatKiller.Data.Model
{
    public class DailyFoodDiary : EntityBase
    {
        public DailyFoodDiary()
        {
            User = new HashSet<User>();
            DailyFoodDiaryProduct = new HashSet<DailyFoodDiaryProduct>();
        }

        [Key]
        [Required]
        public Guid DailyFoodDiaryId { get; set; }

        [ForeignKey("DailyFoodDiaryData")]
        public Guid? DailyFoodDiaryDataId { get; set; }

        public virtual DailyFoodDiaryData DailyFoodDiaryData { get; set; }

        public virtual ICollection<User> User { get; set; }

        public virtual ICollection<DailyFoodDiaryProduct> DailyFoodDiaryProduct { get; set; }
    }
}
