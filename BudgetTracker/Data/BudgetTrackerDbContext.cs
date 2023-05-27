using BudgetTracker.Helpers;
using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Data {
    public class BudgetTrackerDbContext : DbContext {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
        }

        public DbSet<Entry> Entries { get; set; }
    }
}
