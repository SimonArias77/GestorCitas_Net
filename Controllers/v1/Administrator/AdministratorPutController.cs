using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Administrator;

[ApiController]
[Route("api/administrator_put")]
[Tags("administrators")]
public class AdministratorPutController : AdministratorController
{
    public AdministratorPutController(IAdministratorRepository administratorRepository) : base(administratorRepository)
    {
    }

    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
           Summary = "Update administrator information",
           Description = "Updates the details of an existing guest identified by the provided ID."
       )]
    public async Task<IActionResult> UpdateAdministrator(int id, Assessment2.Models.Administrator administrator)
    {
        if (id != administrator.Id)
        {
            return BadRequest();
        }
        await services.Update(administrator);
        return Ok("guest updated");
    }

}
