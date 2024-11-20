using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment2.Seeders;

public class PatientSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasData(
            new Patient
            {
                Id = 1,
                Name = "Juan",
                LastName = "Pérez",
                DateBorn = new DateTime(1985, 5, 12), // Fecha de nacimiento: 12 de mayo de 1985
                PhoneNumber = "1234567890",
                Email = "juan.perez@example.com"
            },
            new Patient
            {
                Id = 2,
                Name = "María",
                LastName = "García",
                DateBorn = new DateTime(1990, 7, 25), // Fecha de nacimiento: 25 de julio de 1990
                PhoneNumber = "9876543210",
                Email = "maria.garcia@example.com"
            },
            new Patient
            {
                Id = 3,
                Name = "Carlos",
                LastName = "López",
                DateBorn = new DateTime(1978, 3, 30), // Fecha de nacimiento: 30 de marzo de 1978
                PhoneNumber = "4567891230",
                Email = "carlos.lopez@example.com"
            },
            new Patient
            {
                Id = 4,
                Name = "Ana",
                LastName = "Martínez",
                DateBorn = new DateTime(1995, 9, 15), // Fecha de nacimiento: 15 de septiembre de 1995
                PhoneNumber = "3216549870",
                Email = "ana.martinez@example.com"
            },
            new Patient
            {
                Id = 5,
                Name = "Luis",
                LastName = "Rodríguez",
                DateBorn = new DateTime(1982, 11, 20), // Fecha de nacimiento: 20 de noviembre de 1982
                PhoneNumber = "7890123456",
                Email = "luis.rodriguez@example.com"
            }
        );
    }
}
