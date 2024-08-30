using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mochi.Service.Models;

namespace Mochi.Service.Data
{
    public class MochiDbContext : DbContext
    {
        public DbSet<LogMessageItem> Logs { get; set; }

        public MochiDbContext(DbContextOptions<MochiDbContext> options) : base(options)
        {

        }
    }
}
