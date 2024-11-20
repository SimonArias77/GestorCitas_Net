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
[Route("api/appointment_put")]
[Tags("appointments")]
public class AppointmentPutController : AppointmentController
{
    public AppointmentPutController(IAppointmentRepository appointmentRepository) : base(appointmentRepository)
    {
    }


    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Update appointment information",
            Description = "Updates the details of an existing appointment identified by the provided ID."
        )]
    public async Task<IActionResult> UpdateAppointment(int id, Assessment2.Models.Appointment appointment)
    {
        if (id != appointment.Id)
        {
            return BadRequest();
        }
        await services.Update(appointment);
        return Ok("appointment updated");
    }

}
