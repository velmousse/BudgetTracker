using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker.Models {
    public class Entry {
        private int Id { get; set; }
        private DateTime Date { get; set; }
        private string Reason { get; set; }
        private decimal Amount { get; set; }

        public Entry(int id, DateTime date, string reason, decimal amount) {
            Id = id;
            Date = date;
            Reason = reason;
            Amount = amount;
        }

    }
}
