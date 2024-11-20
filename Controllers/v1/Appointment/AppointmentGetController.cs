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
[Route("api/appointment_get")]
[Tags("appointments")]
public class AppointmentGetController : AppointmentController
{
    public AppointmentGetController(IAppointmentRepository appointmentRepository) : base(appointmentRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
           Summary = "Get appointment",
           Description = "Retrieves a appointment record"
       )]
    public async Task<IActionResult> GetAllAppointments()
    {
        var appointments = await services.GetAll();
        if (appointments == null || !appointments.Any())
        {
            return NoContent();
        }
        return Ok(appointments);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get appointment by ID",
            Description = "Retrieves a appointment record based on the provided booking ID."
        )]
    public async Task<IActionResult> GetAppointmentById(int id)
    {
        var appointment = await services.GetById(id);
        if (appointment == null)
        {
            return NotFound();
        }
        return Ok(appointment);
    }
}
