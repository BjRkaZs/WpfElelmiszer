using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfElelmiszer
{
        public class ElelmiszerContext : DbContext
        {
            public ElelmiszerContext()
            {
            }

            public DbSet<Elelmiszer> Elelmiszerek { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Elelmiszer;Trusted_Connection=True;");
            }
        }
}
