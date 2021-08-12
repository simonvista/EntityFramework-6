using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                Project project = new Project();
                project.Title = "ASP.NET Core";
                project.Duration = 4;
                project.Fees = 500000;
                db.Projects.Add(project);
                db.SaveChanges();
                Console.WriteLine("project created");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
