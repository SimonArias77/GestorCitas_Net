using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Config;
using Assessment2.DTOs.Requests;
using Assessment2.Models;
using Assessment2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment2.Controllers.v1.Auth;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    protected readonly IAdministratorRepository services;

    public AuthController(IAdministratorRepository administratorRepository)
    {
        services = administratorRepository;
    }

    [HttpPost("login")]
    [SwaggerOperation(
            Summary = "Administrator login",
            Description = "Authenticates an administrator using their email and password, returning a JWT token if successful."
        )]
    public async Task<IActionResult> Login(LoginDto data)
    {
        var administrator = await services.GetByEmail(data.Email);

        if (administrator == null)
            return BadRequest("el usuario no existe");

        if (administrator.Password != data.Password)
            return BadRequest("contraseña incorrecta");

        var token = JWT.GenerateJwtToken(administrator);

        return Ok($"acá está su token: {token}");
    }

    [HttpPost("register")]
    [SwaggerOperation(
            Summary = "Register a new administrator",
            Description = "Creates a new administrator record after validating the provided information and ensuring the email is not already in use."
        )]
    public async Task<IActionResult> Register(RegisterDto data)
    {
        var administrator = await services.GetByEmail(data.Email);

        if (administrator != null)
            return BadRequest("el email ya está registrado");

        administrator = new Models.Administrator
        {

            Email = data.Email,
            Password = data.Password
        };

        await services.Add(administrator);

        return Ok("Usuario registrado correctamente");
    }
}
