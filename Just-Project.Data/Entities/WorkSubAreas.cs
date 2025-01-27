﻿using System;
using System.Collections.Generic;

namespace Just_Project.Data.Entities
{
    public partial class WorkSubAreas : IEntity
    {
        public WorkSubAreas()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdWorkArea { get; set; }

        public virtual WorkAreas IdWorkAreaNavigation { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
