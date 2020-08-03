using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo2.Models
{
    public class EMSDBContext: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-APKG6MF\SQLEXPRESS;Initial Catalog=EMSDB;Persist Security Info=True;User ID=sa;Password=@rR3010@");
        }
    }
}
