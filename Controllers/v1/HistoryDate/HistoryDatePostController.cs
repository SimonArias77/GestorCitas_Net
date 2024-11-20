using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.HistoryDate;

[ApiController]
[Route("api/history_dates_post")]
[Tags("history_dates")]
public class HistoryDatePostController : HistoryDateController
{
    public HistoryDatePostController(IHistoryDateRepository historyDateRepository) : base(historyDateRepository)
    {
    }

    [HttpPost]
    [Authorize] //con esta etiqueta hacemos que el endpoint requiera loguearse para poderlo utilizar. Si la quitamos, podremos trabajar el endpoint sin loguearme
    [SwaggerOperation(
           Summary = "Create a new history date",
           Description = "Creates a new history date record"
       )]
    public async Task<IActionResult> AddHistoryDate(Assessment2.Models.HistoryDates historyDates)
    {
        await services.Add(historyDates);
        return Ok("history dates created");
    }
}
