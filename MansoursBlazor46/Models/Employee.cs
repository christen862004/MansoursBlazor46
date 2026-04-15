namespace MansoursBlazor46.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"Name={Name}\tid={Id}\tSalary={Salary}\tDEpartmentId={DepartmentId}";
        }
    }
}
