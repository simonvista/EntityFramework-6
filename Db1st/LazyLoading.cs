using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1st
{
    class LazyLoading
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            foreach(City city in db.Cities)
            {
                Console.WriteLine($"CityId: {city.CityId}, CityName: {city.CityName}");
                foreach(Area area in city.Areas)
                {
                    Console.WriteLine($"AreaId: {area.AreaId}, AreaName: {area.AreaName}, pincode: {area.Pincode}");
                }
            }
        }
    }
}
