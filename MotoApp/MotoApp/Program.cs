// II - SILA GENERYCZNOSCI W C#
// Ograniczenie new()

using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Adam" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Piotr" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Zuzia" });
employeeRepository.Save();

// Rozwiazanie z generycznym interfacem