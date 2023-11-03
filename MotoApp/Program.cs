using MotoApp.Repositores;
using MotoApp.Entities;

var employeeRepository = new EmployeeRepository();
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Save();