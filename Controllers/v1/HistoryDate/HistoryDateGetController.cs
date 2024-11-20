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
[Route("api/history_date_get")]
[Tags("history_dates")]
public class HistoryDateGetController : HistoryDateController
{
    public HistoryDateGetController(IHistoryDateRepository historyDateRepository) : base(historyDateRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
           Summary = "Get history date",
           Description = "Retrieves a history date record"
       )]
    public async Task<IActionResult> GetAllHistoryDates()
    {
        var historyDates = await services.GetAll();
        if (historyDates == null || !historyDates.Any())
        {
            return NoContent();
        }
        return Ok(historyDates);
    }

    [HttpGet("{id}")]
    [Authorize] // Requires authentication to access this endpoint
    [SwaggerOperation(
            Summary = "Get history date by ID",
            Description = "Retrieves a history date record based on the provided booking ID."
        )]
    public async Task<IActionResult> GetHistoryDateById(int id)
    {
        var historyDates = await services.GetById(id);
        if (historyDates == null)
        {
            return NotFound();
        }
        return Ok(historyDates);
    }
}
