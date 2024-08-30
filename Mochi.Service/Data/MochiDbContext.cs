using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mochi.Service.Models;

namespace Mochi.Service.Data
{
    public class LogDbContext : DbContext
    {
        public DbSet<LogMessageItem> Logs { get; set; }

        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {

        }
    }
}
