using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class Person
    {  // one to one person with vehicle 
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public virtual Vehicle Vehicle { get; set; }
              
    }
}