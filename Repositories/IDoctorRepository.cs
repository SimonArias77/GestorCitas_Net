using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAll();
    Task<Doctor> GetById(int id);

    Task Add(Doctor doctor);
    Task Update(Doctor doctor);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
