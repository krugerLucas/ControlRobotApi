using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ControlRobotApi.Models
{
    public class Context: DbContext
    {
        public DbSet<States> States { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
