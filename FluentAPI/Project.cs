﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class Project
    {
        public int Projectid { get; set; }
        public string ProjName { get; set; }
        public string ProgLanguage { get; set; }
        public string Database { get; set; }
        //navigation property
        //one proj has many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
