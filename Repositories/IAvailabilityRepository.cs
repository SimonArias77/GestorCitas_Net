using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IAvailabilityRepository
{
    Task<IEnumerable<Availability>> GetAll();
    Task<Availability> GetById(int id);
    Task<bool> CheckExistence(int id);
}
