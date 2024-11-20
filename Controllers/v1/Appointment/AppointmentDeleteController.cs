using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Appointment;

[ApiController]
[Route("api/appointment_delete")]
[Tags("appointments")]
public class AppointmentDeleteController : AppointmentController
{
    public AppointmentDeleteController(IAppointmentRepository appointmentRepository) : base(appointmentRepository)
    {
    }

    [HttpDelete]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
           Summary = "Delete a appointment",
           Description = "Deletes a specified appointment record by its ID."
       )]
    public async Task<IActionResult> DeleteAppointment(int id)
    {
        var appointment = await services.GetById(id);
        if (appointment == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("appointment deleted");
    }
}
