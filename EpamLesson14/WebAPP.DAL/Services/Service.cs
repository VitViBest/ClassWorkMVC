using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPP.DAL.EF;
using WebAPP.DAL.Entities;

namespace WebAPP.DAL.Services
{
    public class Service
    {
        private ProjectContext context;

        public Service( ProjectContext project)
        {
            context = project;
        }

        public Project Create(Project project)
        {
            Random r = new Random();
            ProjectTeam team = new ProjectTeam();
            team.EmployeeTimes = new List<EmployeeTime>();
            List<Employee> employees = context.Employees.ToList();
            for(int i = 1; i <= project.Hard * 3; i++)
            {
                bool flag = false;
                Employee employee;
                do
                {
                    employee = employees[r.Next(20)];
                    flag =team.EmployeeTimes.Any(x=>x.Employee== employee)|| context.EmployeeTimes.Count(x => x.EmployeeId == employee.Id&&x.DateLeave<=DateTime.Now)==3;                   
                } while (flag);
                var e = new EmployeeTime() { DateLeave = DateTime.Now.AddDays(project.Hard * 7), Employee = employee };
                team.EmployeeTimes.Add(e);
            }
            team.Name = project.Name + DateTime.Now.Date.ToShortDateString();
            project.ProjectTeams = new List<ProjectTeam>() { team };
            project.DateEnd = DateTime.Now.AddDays(project.Hard * 7);
            context.Projects.Add(project);
            context.SaveChanges();
            return context.Projects.ToList().Last();
        }
    }
}
