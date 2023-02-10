using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Test_web_1.Models
{
    public class ApplicationDbContextClass:DbContext
    {
        public ApplicationDbContextClass(DbContextOptions<ApplicationDbContextClass> options):base(options)
        {
                
        }

        public DbSet<Registration> Registration { get; set; } = null!;
    }
}
