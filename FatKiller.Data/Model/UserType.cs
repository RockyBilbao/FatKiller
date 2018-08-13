using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FatKiller.Data.Model
{
    public class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        [Key]
        [Required]
        public Guid UserTypeId { get; set; }

        public int UserTypeCode { get; set; }

        public string Name { get; set; }

        public ICollection<User> User { get; set; }
    }
}
