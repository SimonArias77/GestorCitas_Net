using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.Appointment;

[ApiController]
[Route("api/appointments")]
public class AppointmentController : ControllerBase
{
    protected readonly IAppointmentRepository services;
    public AppointmentController(IAppointmentRepository appointmentRepository)
    {
        services = appointmentRepository;
    }
}
