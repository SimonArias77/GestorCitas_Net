using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Data;
using Assessment2.Models;
using Assessment2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Services
{
    public class AppointmentServices(ApplicationDbContext context) : IAppointmentRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task Add(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Appointments.AnyAsync(b => b.Id == id);
        }

        public async Task Delete(int id)
        {
            var appointment = await GetById(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetById(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        public async Task<Appointment> GetAvailable()
        {
            return await _context.Appointments.FirstOrDefaultAsync(r => r.Status == "Available");
        }

        public async Task<Appointment> GetOccupied()
        {
            return await _context.Appointments.FirstOrDefaultAsync(r => r.Status == "Occupied");
        }

        public async Task<Appointment> GetStatus()
        {
            return await GetAvailable() ?? await GetOccupied();

        }
        public async Task Update(Appointment appointment)
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        Task<Appointment> IAppointmentRepository.GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}