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
[Route("api/patient_put")]
[Tags("patients")]
public class PatientPutController : PatientController
{
    public PatientPutController(IPatientRepository patientRepository) : base(patientRepository)
    {
    }

    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
         Summary = "Update patient information",
         Description = "Updates the details of an existing patient identified by the provided ID."
     )]
    public async Task<IActionResult> UpdatePatient(int id, Assessment2.Models.Patient patient)
    {
        if (id != patient.Id)
        {
            return BadRequest();
        }
        await services.Update(patient);
        return Ok("patient updated");
    }
}
