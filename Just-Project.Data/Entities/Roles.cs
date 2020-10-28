﻿using System;
using System.Collections.Generic;

namespace Just_Project.Data.Entities
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
