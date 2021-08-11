using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1st
{
    class StudentAddress
    {
        //FK: one student -> one address
        public int StudentId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        //navigation property: one student -> one address
        //public virtual Student Student { get; set; }

    }
}
