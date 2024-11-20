using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.HistoryDate;

[ApiController]
[Route("api/history_dates")]
public class HistoryDateController : ControllerBase
{
    protected readonly IHistoryDateRepository services;
    public HistoryDateController(IHistoryDateRepository historyDateRepository)
    {
        services = historyDateRepository;
    }
}
