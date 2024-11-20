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
    public class AvailabilityServices(ApplicationDbContext context) : IAvailabilityRepository
    {
        private readonly ApplicationDbContext _context = context;
        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Availabilities.AnyAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Availability>> GetAll()
        {
            return await _context.Availabilities.ToListAsync();
        }

        public async Task<Availability> GetById(int id)
        {
            return await _context.Availabilities.FindAsync(id);
        }
    }
}