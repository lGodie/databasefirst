using System;
using System.Collections.Generic;

namespace Just_Project.Data.Entities
{
    public partial class WorkAreas : IEntity
    {
        public WorkAreas()
        {
            WorkSubAreas = new HashSet<WorkSubAreas>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkSubAreas> WorkSubAreas { get; set; }
    }
}
