using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class Developer
    { // mamy to mamy developer with project .................
        [Key]
        public int DevId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }

        public string Adress { get; set; }

    }
}