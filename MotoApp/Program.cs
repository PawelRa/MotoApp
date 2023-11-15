using MotoApp.Repositores;
using MotoApp.Entities;
using MotoApp.Data;

//var employeeGenericRepository = new GenericRepository<Employee>();
//employeeGenericRepository.Add(new Employee { FirstName = "Adam" });
//employeeGenericRepository.Add(new Employee { FirstName = "Zuzia" });
//employeeGenericRepository.Add(new Employee { FirstName = "Piotr" });
//employeeGenericRepository.Save();

var SqlRepository = new SqlRepository(new MotoAppDbContext());
SqlRepository.Add(new Employee { FirstName = "Adam" });
SqlRepository.Add(new Employee { FirstName = "Zuzia" });
SqlRepository.Add(new Employee { FirstName = "Piotr" });
SqlRepository.Save();

var emp = SqlRepository.GetById(1);
Console.WriteLine(emp.ToString());