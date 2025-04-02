// II - SILA GENERYCZNOSCI W C#
// Wprowadzenie - teoria
// Odnalezienie zasobów w twoim projekcie - teoria
// Dostep do zasobow z uzyciem repozytorium - teoria
// Modele danych w twojej aplikacji

using MotoApp.Repositories;

var employeeRepository = new EmployeeRepository();
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Adam" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Piotr" });
employeeRepository.Add(new MotoApp.Entities.Employee { FirstName = "Zuzia" });
employeeRepository.Save();

// Jak napisać generyczne repozytorium