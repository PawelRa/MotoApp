using MotoApp.Repositores;
using MotoApp.Entities;

var employeeGenericRepository = new GenericRepository<Employee>();
employeeGenericRepository.Add(new Employee { FirstName = "Adam" });
employeeGenericRepository.Add(new Employee { FirstName = "Zuzia" });
employeeGenericRepository.Save();