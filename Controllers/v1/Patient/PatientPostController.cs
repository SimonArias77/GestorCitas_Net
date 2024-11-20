using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Patient;

[ApiController]
[Route("api/patient_post")]
[Tags("patients")]
public class PatientPostController : PatientController
{
    public PatientPostController(IPatientRepository patientRepository) : base(patientRepository)
    {
    }

    [HttpPost]
    [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
            Summary = "Create a new patient",
            Description = "Creates a new patient record."
        )]
    public async Task<IActionResult> AddPatient(Assessment2.Models.Patient patient)
    {
        await services.Add(patient);
        return Ok("patient created");
    }
}
