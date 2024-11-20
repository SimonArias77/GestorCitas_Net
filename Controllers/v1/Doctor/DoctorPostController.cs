using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Doctor;


[ApiController]
[Route("api/doctor_post")]
[Tags("doctors")]
public class DoctorPostController : DoctorController
{
    public DoctorPostController(IDoctorRepository doctorRepository) : base(doctorRepository)
    {
    }

    [HttpPost]
    [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
            Summary = "Create a new doctor",
            Description = "Creates a new doctor record for a specified room and guest, ensuring all provided data is valid."
        )]
    public async Task<IActionResult> AddDoctor(Assessment2.Models.Doctor doctor)
    {
        await services.Add(doctor);
        return Ok("doctor created");
    }
}
