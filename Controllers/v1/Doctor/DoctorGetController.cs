using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Doctor;

[ApiController]
[Route("api/doctor_get")]
[Tags("doctors")]
public class DoctorGetController : DoctorController
{
    public DoctorGetController(IDoctorRepository doctorRepository) : base(doctorRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
           Summary = "Get doctor",
           Description = "Retrieves a doctor record"
       )]
    public async Task<IActionResult> GetAllDoctors()
    {
        var doctors = await services.GetAll();
        if (doctors == null || !doctors.Any())
        {
            return NoContent();
        }
        return Ok(doctors);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get doctor by ID",
            Description = "Retrieves a doctor record based on the provided booking ID."
        )]
    public async Task<IActionResult> GetDoctorById(int id)
    {
        var doctor = await services.GetById(id);
        if (doctor == null)
        {
            return NotFound();
        }
        return Ok(doctor);
    }
}
