using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clockify2.Data;
using Microsoft.EntityFrameworkCore;

namespace Clockify2
{
    internal class ClockifyContext: DbContext
    {
       public DbSet<Team> Teams { get; set; }
       public DbSet<Person> Persons { get; set; }
       public DbSet<Data.Task> Tasks { get; set; }
       public DbSet<SubTask> SubTasks { get; set; }
       public DbSet<ActivityLog> Activities { get; set; }
       public DbSet<MembersOfTeam> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Clockify;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
