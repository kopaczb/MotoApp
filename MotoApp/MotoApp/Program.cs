// II - SILA GENERYCZNOSCI W C#
// Rozwiazanie z generycznym interfacem - teoria
// Interface IEnumerable - teoria

using MotoApp.Entities;
using MotoApp.Repositories;

// var employeeRepository = new GenericRepository<Employee, int>();
var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Adam" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Piotr" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Zuzia" });
employeeRepository.Save();

// Tu trzeba zacząć
// Tworzenie Db Context