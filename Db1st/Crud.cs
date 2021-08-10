using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1st
{
    class Crud
    {
        public static void Main(string[] args)
        {
            MyDbEntities db = new MyDbEntities();
            Area areaObj = new Area();
            int opt,id;
            do
            {
                Console.WriteLine("1:new record\n2:display record\n3:update record\n4:delete record\n5:exit");
                Console.Write("your option?");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        //add new record
                        Console.WriteLine("area name?,cityId?,pinCode?");
                        areaObj.AreaName = Console.ReadLine();
                        areaObj.CityId = Convert.ToInt32(Console.ReadLine());
                        areaObj.Pincode = Console.ReadLine();
                        db.Areas.Add(areaObj);
                        db.SaveChanges();
                        break;
                    case 2:
                        //display all records
                        foreach(Area area in db.Areas)
                        {
                            Console.WriteLine($"id: {area.AreaId},name: {area.AreaName},city: {area.City.CityName},pincode: {area.Pincode}");
                        }
                        break;
                    case 3:
                        //update record
                        Console.WriteLine("updated id?");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaObj=db.Areas.Find(id);
                        if (areaObj == null)
                        {
                            Console.WriteLine("no id found");
                        }
                        else
                        {
                            Console.WriteLine("new area name?,new cityId?,new pinCode?");
                            areaObj.AreaName = Console.ReadLine();
                            areaObj.CityId = Convert.ToInt32(Console.ReadLine());
                            areaObj.Pincode = Console.ReadLine();
                            db.SaveChanges();
                        }
                        break;
                    case 4:
                        //delete record
                        Console.WriteLine("deleted id?");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaObj = db.Areas.Find(id);
                        if (areaObj == null)
                        {
                            Console.WriteLine("no id found");
                        }
                        else
                        {
                            db.Areas.Remove(areaObj);
                            db.SaveChanges();
                        }
                        break;
                    case 5:
                        //exit
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (opt != 5);
        }
    }
}
