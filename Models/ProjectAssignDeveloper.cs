using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class ProjectAssignDeveloper
    {  // bridge table 
        [Key]
        public int ProjectAssignDeveloperId { get; set; }
         
        // Remember these step 
        public int DevId { get; set; }
        public virtual Developer Developer { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}