using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDbContext db = new MyDbContext();
                Department dpt = new Department();
                dpt.DeptId = 1;
                dpt.DeptName = "CS";
                db.Departments.Add(dpt);
                db.SaveChanges();
                Console.WriteLine("Department created");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"error: {ex.ToString()}");
            }
            //hold the console open
            Console.ReadKey();
        }
    }
}
