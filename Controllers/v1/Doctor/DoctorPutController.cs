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
[Route("api/doctor_put")]
[Tags("doctors")]
public class DoctorPutController : DoctorController
{
    public DoctorPutController(IDoctorRepository doctorRepository) : base(doctorRepository)
    {
    }

    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
           Summary = "Update doctor information",
           Description = "Updates the details of an existing doctor identified by the provided ID."
       )]
    public async Task<IActionResult> UpdateDoctor(int id, Assessment2.Models.Doctor doctor)
    {
        if (id != doctor.Id)
        {
            return BadRequest();
        }
        await services.Update(doctor);
        return Ok("doctor updated");
    }
}
