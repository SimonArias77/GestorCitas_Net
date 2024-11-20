using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAll();
    Task<Patient> GetById(int id);
    Task Add(Patient patient);
    Task Update(Patient patient);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
