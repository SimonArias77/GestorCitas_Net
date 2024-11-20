using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Availability;

[ApiController]
[Route("api/availability_get")]
[Tags("availabilities")]
public class AvailabilityGetController : AvailabilityController
{
    public AvailabilityGetController(IAvailabilityRepository availabilityRepository) : base(availabilityRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
            Summary = "Get availability",
            Description = "Retrieves a availability record"
        )]
    public async Task<IActionResult> GetAllAvailabilities()
    {
        var availabilities = await services.GetAll();
        if (availabilities == null || !availabilities.Any())
        {
            return NoContent();
        }
        return Ok(availabilities);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get availability by ID",
            Description = "Retrieves a availability record based on the provided availability ID."
        )]
    public async Task<IActionResult> GetAvailabilityById(int id)
    {
        var availability = await services.GetById(id);
        if (availability == null)
        {
            return NotFound();
        }
        return Ok(availability);
    }


}
