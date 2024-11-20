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
[Route("api/history_date_put")]
[Tags("history_dates")]
public class HistoryDatePutController : HistoryDateController
{
    public HistoryDatePutController(IHistoryDateRepository historyDateRepository) : base(historyDateRepository)
    {
    }

    [HttpPut("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
          Summary = "Update history dates information",
          Description = "Updates the details of an existing history dates identified by the provided ID."
      )]
    public async Task<IActionResult> UpdateHistoryDates(int id, Assessment2.Models.HistoryDates historyDates)
    {
        if (id != historyDates.Id)
        {
            return BadRequest();
        }
        await services.Update(historyDates);
        return Ok("history dates updated");
    }
}
