using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1st
{
    class AutoChangeTracking
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            Area area = new Area()
            {
                AreaName = "GreatBoston",
                CityId = 3,
                Pincode = "88888"
            };            
            db.Areas.Add(area);
            Console.WriteLine("After adding Area table"); ;
            foreach (var tracker in db.ChangeTracker.Entries<Area>())
            {
                Console.WriteLine(tracker.State); //Added
            }
            Area alteredArea = db.Areas.Find(9);
            if (alteredArea != null)
            {
                alteredArea.Pincode = "77770";
                Console.WriteLine("After altering Area table");
                foreach (var tracker in db.ChangeTracker.Entries<Area>())
                {
                    Console.WriteLine(tracker.State);  //Added\nModified\n
                }
            }
            Area deletedArea = db.Areas.Find(8);
            if (deletedArea != null)
            {
                db.Areas.Remove(deletedArea);
                Console.WriteLine("after deleting a record in Area table");
                foreach(var tracker in db.ChangeTracker.Entries<Area>())
                {
                    Console.WriteLine(tracker.State); //Added\nModified\nDeleted\n
                }
            }
            // don't save changes in DB
            //db.SaveChanges();
        }
    }
}
