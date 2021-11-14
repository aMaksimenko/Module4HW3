using HomeWork.DataAccess;
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
                db.SaveChanges();
            }
        }
    }
}