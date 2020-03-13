using System;
using System.Collections.Generic;
using PersonalPortfolio.Models;

namespace PersonalPortfolio
{
    public interface IProjectRepository
    {
        public IEnumerable<Project> GetAllProjects();
        public Project GetProject(int id);
    }
}
