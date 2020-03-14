using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using PersonalPortfolio.Models;

namespace PersonalPortfolio
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IDbConnection _conn;

        public ProjectRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _conn.Query<Project>("SELECT * FROM Projects;");
        }

        public Project GetProject(int id)
        {
            return _conn.QuerySingle<Project>("SELECT * FROM Projects WHERE ID = (@ID);", new { ID = id });
        }
    }
}
