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
    public class AdministratorServices(ApplicationDbContext context) : IAdministratorRepository
    {

        private readonly ApplicationDbContext _context = context;

        public async Task Add(Administrator administrator)
        {
            await _context.Administrators.AddAsync(administrator);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Administrators.AnyAsync(b => b.Id == id);
        }

        public async Task Delete(int id)
        {
            var booking = await GetById(id);
            if (booking != null)
            {
                _context.Administrators.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Administrator>> GetAll()
        {
            return await _context.Administrators.ToListAsync();
        }

        public Task<Administrator> GetByEmail(string? email)
        {
            throw new NotImplementedException();
        }

        public async Task<Administrator> GetById(int id)
        {
            return await _context.Administrators.FindAsync(id);
        }

        public async Task Update(Administrator booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
