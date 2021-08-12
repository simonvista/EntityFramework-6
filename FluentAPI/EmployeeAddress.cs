using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    class EmployeeAddress
    {
        //[Key]
        public int EmployeeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        //navigation property
        //one empAdd has one emp
        public virtual Employee Employee { get; set; }
    }
}
