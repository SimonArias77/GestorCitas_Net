using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.Doctor;

[ApiController]
[Route("api/doctors")]
public class DoctorController : ControllerBase
{
    protected readonly IDoctorRepository services;
    public DoctorController(IDoctorRepository doctorRepository)
    {
        services = doctorRepository;
    }
}
