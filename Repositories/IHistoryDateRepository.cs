using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;

namespace Assessment2.Repositories;

public interface IHistoryDateRepository
{
    Task<IEnumerable<HistoryDates>> GetAll();
    Task<HistoryDates> GetById(int id);
    Task Add(HistoryDates historyDates);
    Task Update(HistoryDates historyDates);
    Task<bool> CheckExistence(int id);
}
