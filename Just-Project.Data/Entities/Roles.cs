using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Just_Project.Data.Entities
{
    public partial class Roles : IEntity
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        [JsonIgnore]
        public virtual ICollection<Users> Users { get; set; }
    }
}
