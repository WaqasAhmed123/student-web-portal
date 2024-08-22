using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Data;
using StudentPortalWeb.Models;
using StudentPortalWeb.Models.Entities;
using System.Reflection.Metadata.Ecma335;

namespace StudentPortalWeb.Controllers.Admin
{
    public class ManageStudentController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ManageStudentController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Add()
        {
            return View();
        }


        ////add a user
        //[HttpPost]
        //public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        //{
        //    var student = new Student
        //    {
        //        Name = viewModel.Name,
        //        Email = viewModel.Email,
        //        Phone = viewModel.Phone,
        //        Subscribed = viewModel.Subscribed,
        //    };
        //    await _dbContext.AddAsync(student);
        //    await _dbContext.SaveChangesAsync();
        //    return View();
        //}

        ////get all students
        [HttpGet]                     
        public async Task<IActionResult> List()
        {
            //var students = await _dbContext.Users.ToListAsync();

            //get student role id
            var studentRoleId = await _dbContext.Roles
        .Where(r => r.Name == "Student")
        .Select(r => r.Id)
        .FirstOrDefaultAsync();

            var students = await _dbContext.Users
                .Where(u => u.UserRoles.Any(ur => ur.RoleId == studentRoleId))
                .ToListAsync();
            return View("~/Views/Admin/ManageStudent/List.cshtml", students);
            //return View(students);
        }

        ////get particular student for editing
        //[HttpGet]
        //public async Task<IActionResult> Edit(Guid id)
        //{
        //    var student = await _dbContext.Students.FindAsync(id);
        //    return View(student);
        //}

        ////editing and save
        //[HttpPost]
        //public async Task<IActionResult> Edit(Student viewModel)
        //{

        //    var student = await _dbContext.Students.FindAsync(viewModel.Id);
        //    if (student is not null)
        //    {
        //        student.Name = viewModel.Name;
        //        student.Email = viewModel.Email;
        //        student.Phone = viewModel.Phone;
        //        student.Subscribed = viewModel.Subscribed;

        //        await _dbContext.SaveChangesAsync();
        //    }

        //    return RedirectToAction("List", "Students");
        //}

        //deleting a student
        //[HttpPost]
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    var student = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
        //    _dbContext.Remove(student);
        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("List", "Students");
        //}

    }
}
