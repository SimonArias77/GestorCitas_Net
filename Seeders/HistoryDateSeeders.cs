using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Seeders;

public class HistoryDateSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistoryDates>().HasData(
               new HistoryDates
               {
                   Id = 1,
                   DateTime = new DateTime(2024, 10, 15, 9, 0, 0), // Fecha y hora: 15 de octubre de 2024, 9:00 AM
                   Reason = "Consulta inicial por dolores de cabeza frecuentes",
                   AppointmentId = 1 // Relación con cita existente
               },
               new HistoryDates
               {
                   Id = 2,
                   DateTime = new DateTime(2024, 10, 18, 11, 30, 0), // Fecha y hora: 18 de octubre de 2024, 11:30 AM
                   Reason = "Revisión de resultados de análisis de sangre",
                   AppointmentId = 2 // Relación con cita existente
               },
               new HistoryDates
               {
                   Id = 3,
                   DateTime = new DateTime(2024, 10, 20, 15, 0, 0), // Fecha y hora: 20 de octubre de 2024, 3:00 PM
                   Reason = "Seguimiento de tratamiento para hipertensión",
                   AppointmentId = 3 // Relación con cita existente
               }
           );
    }


}

