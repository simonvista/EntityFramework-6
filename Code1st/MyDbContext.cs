using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class MyDbContext:DbContext
    {
        // StudentDB will be the name of DB
        // w/o connectionString defined, StudentDB will be created on localdb rather than .
        public MyDbContext():base("StudentDB1")
        {

        }
        //StudentDB DB has 4 tables
        //virtual -> lazy loading
        public virtual DbSet<Student> Students { get; set; }
        //public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}
