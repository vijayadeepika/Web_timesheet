using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webtimesheet_practicing.models;

namespace webtimesheet_pacticing.concrete
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=cs")
        {
        }

        public DbSet<Registration> Registration { get; set; }
        public DbSet<Roles> Role { get; set; }
        //public DbSet<ProjectMaster> ProjectMaster { get; set; }
        //public DbSet<TimeSheetMaster> TimeSheetMaster { get; set; }
        //public DbSet<TimeSheetDetails> TimeSheetDetails { get; set; }
        //public DbSet<ExpenseModel> ExpenseModel { get; set; }
        //public DbSet<Documents> Documents { get; set; }
        //public DbSet<TimeSheetAuditTB> TimeSheetAuditTB { get; set; }
        //public DbSet<ExpenseAuditTB> ExpenseAuditTB { get; set; }
        public DbSet<AuditTB> AuditTB { get; set; }

        public System.Data.Entity.DbSet<webtimesheet_practicing.models.LoginViewModel> LoginViewModels { get; set; }
        //public DbSet<DescriptionTB> DescriptionTB { get; set; }
        //public DbSet<AssignedRoles> AssignedRoles { get; set; }


    }
}
