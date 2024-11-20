using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Data;
using Assessment2.Models;
using Assessment2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Services;

public class PatientServices(ApplicationDbContext context) : IPatientRepository
{
    private readonly ApplicationDbContext _context = context;
    public async Task Add(Patient patient)
    {
        await _context.Patients.AddAsync(patient);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.Patients.AnyAsync(b => b.Id == id);
    }

    public async Task Delete(int id)
    {
        var patient = await GetById(id);
        if (patient != null)
        {
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Patient>> GetAll()
    {
        return await _context.Patients.ToListAsync();
    }

    public async Task<Patient> GetById(int id)
    {
        return await _context.Patients.FindAsync(id);
    }

    public async Task Update(Patient patient)
    {
        _context.Entry(patient).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
