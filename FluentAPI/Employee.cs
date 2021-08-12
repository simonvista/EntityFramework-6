using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }

        //foreign keys
        public int DepartmentId { get; set; }
        public int? TeamId { get; set; }

        //navigation property
        //one emp has one dept
        public virtual Department Department { get; set; }
        //one emp has one add
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        //one emp has one team
        public virtual Team Team { get; set; }
        //one emp has many projects
        public virtual ICollection<Project> Projects { get; set; }
    }
}
