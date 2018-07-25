using FatKiller.Data.Model.ModelsBase;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace FatKiller.Data.Model
{
    public class User : EntityBase
    {
        [Key]
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [ForeignKey("UserData")]
        public Guid UserDataId { get; set; }

        public virtual UserData UserData { get; set; }

        [ForeignKey("DailyFoodDiary")]
        public Guid DailyFoodDiaryId { get; set; }

        public virtual DailyFoodDiary DailyFoodDiary { get; set; }
    }
}
