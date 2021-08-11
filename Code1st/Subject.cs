using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class Subject
    {
        public int Subjectid { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        //navigation property: many subjects <-> many projects
        public virtual ICollection<Project> Projects { get; set; }
    }
}
