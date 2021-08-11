using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class Project
    {
        // Id -> PK
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public float Fees { get; set; }
        //navigation property: one project -> many students, many subjects <-> many projects
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
