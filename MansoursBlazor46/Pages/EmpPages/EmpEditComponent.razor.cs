using MansoursBlazor46.Models;
using MansoursBlazor46.Services;
using Microsoft.AspNetCore.Components;

namespace MansoursBlazor46.Pages.EmpPages
{
    public partial class EmpEditComponent
    {
        [Parameter]
        public int id { get; set; }
        public Employee EmployeeObj { get; set; }
        [Inject]
        public IService<Employee>   EmpService { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }
        protected override void OnInitialized()
        {
            EmployeeObj = EmpService.GetByID(id);
            base.OnInitialized();
        }
        public void Save()
        {
            //web api save 
            Console.WriteLine("Save Success");
            NavManager.NavigateTo("/emps");
        }
        public void ShowMsg()
        {
            Console.WriteLine("Model Invalid");
        }
    }
}
