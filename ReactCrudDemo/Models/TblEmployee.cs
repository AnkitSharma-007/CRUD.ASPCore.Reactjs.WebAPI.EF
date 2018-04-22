using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}
