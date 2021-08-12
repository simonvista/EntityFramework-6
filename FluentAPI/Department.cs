using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Department
    {
        //DeptId is not PK b/c it isn't following <className>Id naming convention
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        //navigation property
        //one dept has many emplyees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
