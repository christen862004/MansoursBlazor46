using MansoursBlazor46.Models;

namespace MansoursBlazor46.Pages
{
    public partial class DepartmentComponent
    {
        public int SelectDeptId { get; set; }
        public List<Department> DeptList { get; set; }
        public Department   DepartmentObj { get; set; }
        public DepartmentComponent()
        {
            DeptList = new List<Department>() {
                new Department() { Id = 1, Name = "SD", Manager = "Ahmed" },
                new Department() { Id = 2, Name = "OS", Manager = "Mohamed" },
                new Department() { Id = 3, Name = "UI", Manager = "Hussien" }
            };
            //DepartmentObj = new Department() { Id = 1, Name = "sD", Manager = "Ahmed" };
        }
        public void GetDept()
        {
            //get select department id
            //fiulter list get dep[t
            //departmentobj
            DepartmentObj = DeptList.FirstOrDefault(d => d.Id == SelectDeptId);
        }
    }
}
