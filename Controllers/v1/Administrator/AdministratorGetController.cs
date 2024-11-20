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
[Route("api/administrator_get")]
[Tags("administrators")]
public class AdministratorGetController : AdministratorController
{
    public AdministratorGetController(IAdministratorRepository administratorRepository) : base(administratorRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
           Summary = "Get administrator",
           Description = "Retrieves a administrator record"
       )]
    public async Task<IActionResult> GetAllAdministrators()
    {
        var administrators = await services.GetAll();
        if (administrators == null || !administrators.Any())
        {
            return NoContent();
        }
        return Ok(administrators);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get administrator by ID",
            Description = "Retrieves a administrator record based on the provided booking ID."
        )]
    public async Task<IActionResult> GetAdministratorById(int id)
    {
        var administrator = await services.GetById(id);
        if (administrator == null)
        {
            return NotFound();
        }
        return Ok(administrator);
    }
}

