using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Just_Project.Domain.Services;
using Just_Project.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Just_Project.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleServices _roleService;

        public RolesController(
             IRoleServices roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("FindAll")]
        public async Task<ActionResult> FindAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(await _roleService.GetAll());

            }
            catch (Exception ex)
            {

                return BadRequest();
            }

        }

    }
}
