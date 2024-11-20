using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers.v1.Administrator;

[ApiController]
[Route("api/administrators")]
public class AdministratorController : ControllerBase
{
    protected readonly IAdministratorRepository services;
    public AdministratorController(IAdministratorRepository administratorRepository)
    {
        services = administratorRepository;
    }
}
