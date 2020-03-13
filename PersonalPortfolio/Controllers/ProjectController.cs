using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalPortfolio.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IProjectRepository repo;

        public ProjectController(IProjectRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var projects = repo.GetAllProjects();
            return View(projects);
        }

        public IActionResult ViewProject(int id)
        {
            var project = repo.GetProject(id);
            return View(project);
        }
    }
}
