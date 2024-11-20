using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IAppointmentRepository
{
    Task<IEnumerable<Appointment>> GetAll();
    Task<Appointment> GetById(int id);
    Task<Appointment> GetAvailable();
    Task<Appointment> GetOccupied();
    Task<Appointment> GetStatus();
    Task Add(Appointment appointment);
    Task Update(Appointment appointment);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}
