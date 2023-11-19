using MotoApp.Repositores;
using MotoApp.Entities;
using MotoApp.Data;

//var ListRepository = new ListRepository<Employee>();
//ListRepository.Add(new Employee { FirstName = "Adam" });
//ListRepository.Add(new Employee { FirstName = "Zuzia" });
//ListRepository.Add(new Employee { FirstName = "Piotr" });
//ListRepository.Save();

var SqlRepository = new SqlRepository<Employee>(new MotoAppDbContext());
SqlRepository.Add(new Employee { FirstName = "Adam" });
SqlRepository.Add(new Employee { FirstName = "Zuzia" });
SqlRepository.Add(new Employee { FirstName = "Piotr" });
SqlRepository.Save();

var emp = SqlRepository.GetById(1);
Console.WriteLine(emp.ToString());