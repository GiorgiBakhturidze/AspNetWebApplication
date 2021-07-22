using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.ApplicationModels;
using Microsoft.AspNetCore.Identity;

namespace Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B3Q553I;Initial Catalog=WebAppDatabase;Integrated Security=True");
        }
    }
}
