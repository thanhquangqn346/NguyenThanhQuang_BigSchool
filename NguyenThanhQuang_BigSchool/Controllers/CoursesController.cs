using NguyenThanhQuang_BigSchool.Models;
using NguyenThanhQuang_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenThanhQuang_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _dbContext;

        private readonly ApplicationDbContext_dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
         
    }
}