using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1st
{
    class EagerLoading
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            // Include("Areas") -> eager loading
            foreach (City city in db.Cities.Include("Areas"))
            {
                Console.WriteLine($"CityId: {city.CityId}, CityName: {city.CityName}");
                foreach(Area area in city.Areas)
                {
                    Console.WriteLine($"AreaName: {area.AreaName}");
                }
            }
        }
    }
}
