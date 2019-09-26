using EpamLesson14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPP.DAL.EF;
using WebAPP.DAL.Entities;
using WebAPP.DAL.Services;

namespace EpamLesson14.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Project project)
        {
            Service service = new Service(new WebAPP.DAL.EF.ProjectContext());
            var p = service.Create(project);
            SuccessVM success = new SuccessVM() { Employees = p.ProjectTeams.First().EmployeeTimes.ToList(), End = p.DateEnd };
            return View("Success",success);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Show()
        {
            ShowVM show = new ShowVM();
            show.Projects = new ProjectContext().Projects.ToList().Select(x => new { i = x.Id, t = x.Name }).ToDictionary(x => x.i, x => x.t);
            return View(show);
        }

        public ActionResult Details(int? id)
        {
            DetailsVM details = new DetailsVM() { Project= new ProjectContext().Projects.ToList().First(x => x.Id == id) }; 
            return View(details);
        }

        public ActionResult Employees()
        {
            EmployeesVM details = new EmployeesVM() { Employees = new ProjectContext().Employees.ToList() };
            return View(details);
        }
    }
}