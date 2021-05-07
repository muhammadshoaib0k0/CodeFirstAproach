using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class Vehicle
    {
        [Key]
        [ForeignKey("Person")]
         public int PersonId { get; set; }
        public string VehicleName { get; set; }

        public virtual Person Person { get; set; }




    }
}