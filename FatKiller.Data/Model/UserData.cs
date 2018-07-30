using FatKiller.Data.Model.ModelsBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatKiller.Data.Model
{
    public class UserData : EntityBase
    {
        public UserData()
        {
            User = new HashSet<User>();
        }

        [Key]
        [Required]
        public Guid UserdDataId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
