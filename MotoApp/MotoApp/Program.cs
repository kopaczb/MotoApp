// II - SILA GENERYCZNOSCI W C#
// Dziedziczenie typow generycznych

using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Adam" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Piotr" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Zuzia" });
employeeRepository.Save();

// Wiele typow generycznych w jednej klasie