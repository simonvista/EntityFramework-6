using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db1st
{
    class RawSqlQueries
    {
        public static void Main(string[] args)
        {
            //Raw SQL queries for entities
            MyDbEntities db = new MyDbEntities();
            //w/o params
            //IEnumerable<Area> areaList=  db.Areas.SqlQuery("select * from areas where cityid=1");
            //w/ params
            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@myId";
            sp.Value = 1;
            sp.SqlDbType = System.Data.SqlDbType.Int;
            IEnumerable<Area> areaList = db.Areas.SqlQuery("select * from areas where cityid=@myId",sp);
            foreach (Area area in areaList)
            {
                Console.WriteLine($"AreaId: {area.AreaId}, AreaName: {area.AreaId}, Pincode: {area.Pincode}");
            }
        }
    }
}
