using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Module4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("Config.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBuilder.UseSqlServer(connectionString).Options;
            using (var db = new ApplicationContext(options))
            {
                db.SaveChanges();
            }

            Console.Read();
        }
    }
}
