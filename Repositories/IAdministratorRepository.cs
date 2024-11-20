using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IAdministratorRepository
{
    Task<IEnumerable<Administrator>> GetAll();
    Task<Administrator> GetById(int id);
    Task Add(Administrator administrator);
    Task Update(Administrator administrator);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
    Task<Administrator> GetByEmail(string? email);
}
