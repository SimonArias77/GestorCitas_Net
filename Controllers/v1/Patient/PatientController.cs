using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.Patient;

[ApiController]
[Route("api/patients")]
public class PatientController : ControllerBase
{
    protected readonly IPatientRepository services;
    public PatientController(IPatientRepository patientRepository)
    {
        services = patientRepository;
    }
}
