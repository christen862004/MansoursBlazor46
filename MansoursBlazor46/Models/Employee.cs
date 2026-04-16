using System.ComponentModel.DataAnnotations;

namespace MansoursBlazor46.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        [MinLength(3,ErrorMessage ="Name must be more than 2 chars")]
        public string Name { get; set; }
        [Range(8000,50000)]
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"Name={Name}\tid={Id}\tSalary={Salary}\tDEpartmentId={DepartmentId}";
        }
    }
}
