using MotoApp.Repositores;
using MotoApp.Entities;
using MotoApp.Data;

//var ListRepository = new ListRepository<Employee>();
//ListRepository.Add(new Employee { FirstName = "Adam" });
//ListRepository.Add(new Employee { FirstName = "Zuzia" });
//ListRepository.Add(new Employee { FirstName = "Piotr" });
//ListRepository.Save();

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Add(new Employee { FirstName = "Piotr" });
employeeRepository.Save();

GetEmployeeById(employeeRepository);

static void GetEmployeeById(IRepository<IEntity> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}