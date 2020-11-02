using System;
using System.Collections.Generic;

namespace Just_Project.Data.Entities
{
    public partial class IdentificationTypes : IEntity
    {
        public IdentificationTypes()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
