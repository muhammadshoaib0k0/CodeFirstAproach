using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstAproach.Models
{
    public class CodeFirstContext:DbContext
    {
        // yeh class hamara database sa intraction karva rahi ho gee
        public CodeFirstContext() : base("Constr") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<CodeFirstAproach.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<CodeFirstAproach.Models.Vehicle> Vehicles { get; set; }

        public System.Data.Entity.DbSet<CodeFirstAproach.Models.Developer> Developers { get; set; }

        public System.Data.Entity.DbSet<CodeFirstAproach.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<CodeFirstAproach.Models.ProjectAssignDeveloper> ProjectAssignDevelopers { get; set; }
    }
}