using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Data;
using StudentPortalWeb.Models;
using StudentPortalWeb.Models.Entities;
using System.Reflection.Metadata.Ecma335;

namespace StudentPortalWeb.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CourseController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public IActionResult Add()
        //{
        //    return View();
        //}


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
        //[HttpGet]
        //public async Task<IActionResult> List()
        //{
        //    var students = await _dbContext.Students.ToListAsync();
        //    return View(students);
        //}

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
