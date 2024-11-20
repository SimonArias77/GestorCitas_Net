using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Data;
using Assessment2.Models;
using Assessment2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Services;

public class DoctorServices(ApplicationDbContext context) : IDoctorRepository
{
    private readonly ApplicationDbContext _context = context;
    public async Task Add(Doctor doctor)
    {
        await _context.Doctors.AddAsync(doctor);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Doctors.AnyAsync(e => e.Id == id);
    }

    public async Task Delete(int id)
    {
        var doctor = await GetById(id);
        if (doctor != null)
        {
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Doctor>> GetAll()
    {
        return await _context.Doctors.ToListAsync();
    }

    public async Task<Doctor> GetById(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }

    public async Task Update(Doctor doctor)
    {
        _context.Entry(doctor).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
