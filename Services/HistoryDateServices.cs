using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Data;
using Assessment2.Models;
using Assessment2.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Services;

public class HistoryDateServices(ApplicationDbContext context) : IHistoryDateRepository
{
    private readonly ApplicationDbContext _context = context;
    public async Task Add(HistoryDates historyDates)
    {
        await _context.HistoryDates.AddAsync(historyDates);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await _context.HistoryDates.AnyAsync(b => b.Id == id);
    }

    public async Task<IEnumerable<HistoryDates>> GetAll()
    {
        return await _context.HistoryDates.ToListAsync();
    }

    public async Task<HistoryDates> GetById(int id)
    {
        return await _context.HistoryDates.FindAsync(id);
    }

    public async Task Update(HistoryDates historyDates)
    {
        _context.Entry(historyDates).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
