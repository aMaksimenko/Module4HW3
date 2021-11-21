using System;
using System.Linq;
using HomeWork.DataAccess;
using HomeWork.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var contextOptions = new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(configuration.GetConnectionString("HomeWork"))
                .Options;

            using (var db = new ApplicationContext(contextOptions))
            {
                db.Database.Migrate();

                /*var leftJoin = (from p in db.Projects
                    join c in db.Clients on p.ClientId equals c.Id into projectsClients
                    from pc in projectsClients.DefaultIfEmpty()
                    join ep in db.EmployeeProjects on p.Id equals ep.ProjectId into projectsClientsEmployeeProjects
                    from pcep in projectsClientsEmployeeProjects.DefaultIfEmpty()
                    select new
                    {
                        ClientTitle = pc.Title,
                        ProjectTitle = p.Name,
                        pcep.EmployeeId
                    }).ToList();*/

                /*var dateDiff = db.Employees.Select(e => new
                {
                    dateDiff = EF.Functions.DateDiffDay(e.HiredDate, DateTime.Now)
                });

                foreach (var item in dateDiff)
                {
                    Console.WriteLine(item.dateDiff);
                }*/

                /*var projectOne = db.Projects.First(p => p.Id == 1);
                var projectTwo = db.Projects.First(p => p.Id == 2);

                projectOne.Name = "Smart Home";
                projectTwo.Name = "Autopilot";

                db.Projects.Update(projectOne);
                db.Projects.Update(projectTwo);*/

                /*var newEmployee = new Employee()
                {
                    FirstName = "James",
                    LastName = "Bond",
                    HiredDate = new DateTime(2018, 5, 15),
                    DateOfBirth = new DateTime(1990, 10, 31),
                    OfficeId = 2,
                    Title = new Title()
                    {
                        Name = "DevOps"
                    }
                };
                var newProject = new Project()
                {
                    Name = "SpaceX",
                    Budget = 100M,
                    StartedDate = new DateTime(1995, 8, 10),
                    ClientId = 2
                };

                db.Employees.Add(newEmployee);
                db.Projects.Add(newProject);*/

                /*var deleteEmployee = db.Employees.First(e => e.Id == 1);

                db.Employees.Remove(deleteEmployee);*/

                /*var title = db.Employees
                    .GroupBy(e => e.Title.Name)
                    .Select(e => e.Key)
                    .Where(k => !EF.Functions.Like(k, "%a%"))
                    .ToList();*/

                db.SaveChanges();
            }
        }
    }
}