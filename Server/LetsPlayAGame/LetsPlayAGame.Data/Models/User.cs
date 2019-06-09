using System;
using System.Collections.Generic;

namespace LetsPlayAGame.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string  UserName { get; set; }

        public virtual Character Character { get; set; }

        public virtual List<UserRoles> Roles { get; set; }
    }
}
