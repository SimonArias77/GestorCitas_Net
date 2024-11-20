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
[Route("api/administrator_delete")]
[Tags("administrators")]
public class AdministratorDeleteController : AdministratorController
{
    public AdministratorDeleteController(IAdministratorRepository administratorRepository) : base(administratorRepository)
    {
    }

    [HttpDelete]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
             Summary = "Delete a administrator",
             Description = "Deletes a specified administrator record by its ID."
         )]
    public async Task<IActionResult> DeleteAdministrator(int id)
    {
        var administrator = await services.GetById(id);
        if (administrator == null)
        {
            return NotFound();
        }
        await services.Delete(id);
        return Ok("administrator deleted");
    }

}
