using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Appointment;

[ApiController]
[Route("api/appointment_post")]
[Tags("appointments")]
public class AppointmentPostController : AppointmentController
{
    public AppointmentPostController(IAppointmentRepository appointmentRepository) : base(appointmentRepository)
    {
    }

    [HttpPost]
    // [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
           Summary = "Create a new appointment",
           Description = "Creates a new appointment record."
       )]
    public async Task<IActionResult> AddAppointment(Assessment2.Models.Appointment appointment)
    {
        await services.Add(appointment);
        return Ok("booking created");
    }
}
