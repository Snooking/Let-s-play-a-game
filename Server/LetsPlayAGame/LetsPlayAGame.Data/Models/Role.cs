using System;
using System.Collections.Generic;

namespace LetsPlayAGame.Data.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<UserRoles> Users { get; set; }
    }
}
