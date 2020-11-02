using Just_Project.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Project.Domain.Services.Interfaces
{
    public interface IRoleServices
    {
        Task<IEnumerable<Roles>> GetAll();
    }
}
