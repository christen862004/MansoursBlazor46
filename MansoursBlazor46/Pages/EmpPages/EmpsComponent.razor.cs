using MansoursBlazor46.Models;
using MansoursBlazor46.Services;
using Microsoft.AspNetCore.Components;

namespace MansoursBlazor46.Pages.EmpPages
{
    public partial class EmpsComponent
    {
        //declare service
        [Inject]
        public IService<Employee> empService { get; set; }
        //list
        public List<Employee>   EmpList { get; set; }

        protected override void OnInitialized()
        {
            //empService=new EmployeeService();
            EmpList = empService.GetAll();
            base.OnInitialized();        
        }
    }
}
