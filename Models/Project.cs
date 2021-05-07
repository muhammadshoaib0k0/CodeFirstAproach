﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstAproach.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string Description { get; set; }
    }
}