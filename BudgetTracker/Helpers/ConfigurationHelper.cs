using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Helpers
{
    public static class ConfigurationHelper
    {
        public static string ConnectionString { get; set; } = "Host=10.0.0.131;Port=5432;Database=BudgetTrackerDb;User Id=pi;Password=raspberry;";
    }
}
