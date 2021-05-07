using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public int  Age { get; set; }

        public virtual Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}