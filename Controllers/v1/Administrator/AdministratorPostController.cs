using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Administrator;

[ApiController]
[Route("api/administrator_post")]
[Tags("administrators")]
public class AdministratorPostController : AdministratorController
{
    public AdministratorPostController(IAdministratorRepository administratorRepository) : base(administratorRepository)
    {
    }

    [HttpPost]
    [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
            Summary = "Create a new administrator",
            Description = "Creates a new administrator record for a specified room and guest, ensuring all provided data is valid."
        )]
    public async Task<IActionResult> AddOrderProduct(Assessment2.Models.Administrator administrator)
    {
        await services.Add(administrator);
        return Ok("administrator created");
    }
}
