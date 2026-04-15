using MansoursBlazor46.Models;

namespace MansoursBlazor46.Services
{
    public class EmployeeService : IService<Employee>
    {
        List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>() { 
                new Employee(){Id=1,Name="Ahmed" ,Salary=30000,DepartmentId=1},
                new Employee(){Id=2,Name="Mohamed" ,Salary=30000,DepartmentId=2},
                new Employee(){Id=3,Name="Hussien" ,Salary=30000,DepartmentId=3},
            };
        }
        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetByID(int id)
        {
            return _employees.FirstOrDefault(e=>e.Id==id);
        }
    }
}
