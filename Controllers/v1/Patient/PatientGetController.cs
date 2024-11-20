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
[Route("api/patient_get")]
[Tags("patients")]
public class PatientGetController : PatientController
{
    public PatientGetController(IPatientRepository patientRepository) : base(patientRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
          Summary = "Get patient",
          Description = "Retrieves a patient record"
      )]
    public async Task<IActionResult> GetAllPatients()
    {
        var patients = await services.GetAll();
        if (patients == null || !patients.Any())
        {
            return NoContent();
        }
        return Ok(patients);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get patient by ID",
            Description = "Retrieves a patient record."
        )]
    public async Task<IActionResult> GetPatientById(int id)
    {
        var patient = await services.GetById(id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }
}
