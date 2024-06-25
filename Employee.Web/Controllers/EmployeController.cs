using Employee.Web.Data;
using Employee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Employee.Web.Controllers
{
    public class EmployeController : Controller
    {
        public EmployeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
         public async Task<IActionResult> List()
        {
            var students = await DbContext.Studemts.ToListAsync()
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel viewModel) 
        {
            var emplyee = new employe
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Probation = viewModel.Probation


            };

          
            await DbContext.Employe.AddAsync(emplyee)
            await DbContext.SaveChangesAsync();

            return View();
        }
}
