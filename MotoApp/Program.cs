using MotoApp.Repositores;
using MotoApp.Entities;

var employeeRepository = new EmployeeRepository();
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Save();

var employeeGenericRepository = new GenericRepository<Employee, Guid>();
employeeGenericRepository.Add(new Employee { FirstName = "Adam" });
employeeGenericRepository.Add(new Employee { FirstName = "Zuzia" });
employeeGenericRepository.Save();