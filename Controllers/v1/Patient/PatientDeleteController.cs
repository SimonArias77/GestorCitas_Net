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
[Route("api/patient_delete")]
[Tags("patients")]
public class PatientDeleteController : PatientController
{
    public PatientDeleteController(IPatientRepository patientRepository) : base(patientRepository)
    {
    }

    [HttpDelete]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Delete a patient",
            Description = "Deletes a specified patient record by its ID."
        )]
    public async Task<IActionResult> DeletePatient(int id)
    {
        var patient = await services.GetById(id);
        if (patient == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("patient deleted");
    }
}
