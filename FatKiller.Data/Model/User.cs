using FatKiller.Data.Model.ModelsBase;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FatKiller.Data.Model
{
    public class User : EntityBase
    {
        [Key]
        [Required]
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        [ForeignKey("UserData")]
        public Guid? UserDataId { get; set; }

        public virtual UserData UserData { get; set; }

        [ForeignKey("DailyFoodDiary")]
        public Guid? DailyFoodDiaryId { get; set; }

        public virtual DailyFoodDiary DailyFoodDiary { get; set; }

        [ForeignKey("UserType")]
        public Guid? UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
