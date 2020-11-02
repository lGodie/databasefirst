using Just_Project.Data.Entities;
using Just_Project.Data.Repositories.Interface;
using Just_Project.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Project.Domain.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly IGenericRepository<Roles> _genericRepository;

        public RoleServices(IGenericRepository<Roles> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Task<IEnumerable<Roles>> GetAll()
        {
            return _genericRepository.GetAll();
        }
    }
}
