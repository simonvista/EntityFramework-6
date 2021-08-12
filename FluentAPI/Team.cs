using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Size { get; set; }
        //navigation property
        //one team has many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
