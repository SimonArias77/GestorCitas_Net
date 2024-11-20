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
[Route("api/doctor_delete")]
[Tags("doctors")]
public class DoctorDeleteController : DoctorController
{
    public DoctorDeleteController(IDoctorRepository doctorRepository) : base(doctorRepository)
    {
    }

    [HttpDelete]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Delete a doctor",
            Description = "Deletes a specified doctor record by its ID."
        )]
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        var doctor = await services.GetById(id);
        if (doctor == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("doctor deleted");
    }
}
