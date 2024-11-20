using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.Availability;

[ApiController]
[Route("api/availabilities")]
public class AvailabilityController : ControllerBase
{
    protected readonly IAvailabilityRepository services;
    public AvailabilityController(IAvailabilityRepository availabilityRepository)
    {
        services = availabilityRepository;
    }
}
