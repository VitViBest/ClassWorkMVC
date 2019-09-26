using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPP.DAL.Entities;

namespace WebAPP.DAL.EF
{
    public class ProjectContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTeam> ProjectTeams { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeTime> EmployeeTimes { get; set; }

        static ProjectContext()
        {
            Database.SetInitializer<ProjectContext>(new DbInitializer());
        }

        public class DbInitializer :DropCreateDatabaseAlways<ProjectContext>
        {
            protected override void Seed(ProjectContext context)
            {

                Employee[] employees = new Employee[20];
                employees[0]=new Employee() { Name = "Иван" };
                employees[1]=new Employee() { Name = "Виталий" };
                employees[2]=new Employee() { Name = "Славик" };
                employees[3]=new Employee() { Name = "Игорь" };
                employees[4]=new Employee() { Name = "Стас" };
                employees[5]=new Employee() { Name = "Николай" };
                employees[6]=new Employee() { Name = "Артем" };
                employees[7]=new Employee() { Name = "Макс" };
                employees[8]=new Employee() { Name = "Влад" };
                employees[9]=new Employee() { Name = "Егор" };
                employees[10]=new Employee() { Name = "Дима" };
                employees[11]=new Employee() { Name = "Вадим" };
                employees[12]=new Employee() { Name = "Кирилл" };
                employees[13]=new Employee() { Name = "Данил" };
                employees[14]=new Employee() { Name = "Степан" };
                employees[15]=new Employee() { Name = "Рома" };
                employees[16]=new Employee() { Name = "Василий" };
                employees[17]=new Employee() { Name = "Андрей" };
                employees[18]=new Employee() { Name = "Руслан" };
                employees[19]=new Employee() { Name = "Миша" };
                context.Employees.AddRange(employees);
                base.Seed(context);
            }
        }
    }
}