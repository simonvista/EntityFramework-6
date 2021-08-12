using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsBonsfied { get; set; }
        public string ContactNo { get; set; }

        public string Email { get; set; }

        //navigation property: one student -> one project, one student -> one address
        public virtual Project Project { get; set; }
        //public virtual StudentAddress StudentAddress { get; set; }
    }
}
