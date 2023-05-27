using BudgetTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Data.Repositories {
    public class EntryRepository : IEntryRepository {

        private readonly BudgetTrackerDbContext context;

        public EntryRepository(BudgetTrackerDbContext context) {
            this.context = context;
        }
        public IEnumerable<Entry> GetEntries() {
            return context.Entries.ToList();
        }
        public Entry Get(int id) {
            return context.Entries.Find(id);
        }
        public void InsertEntry(Entry entry) {
            context.Entries.Add(entry);
        }

        public void DeleteEntry(int id) {
            Entry entry = context.Entries.Find(id);
            context.Entries.Remove(entry);
        }

        public void UpdateEntry(Entry entry) {
            context.Entry(entry).State = EntityState.Modified;
        }

        public void Save() {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) { 
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
