using BudgetTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Data.Repositories {
    public interface IEntryRepository : IDisposable {
        IEnumerable<Entry> GetEntries();
        Entry Get(int id);
        void InsertEntry(Entry entry);
        void DeleteEntry(int id);
        void UpdateEntry(Entry entry);
        void Save();
    }
}
