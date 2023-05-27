using BudgetTracker.Data;
using BudgetTracker.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetTracker {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private readonly BudgetTrackerDbContext context;
        private readonly IEntryRepository entryRepository;

        public MainWindow(BudgetTrackerDbContext context, IEntryRepository entryRepository) {
            this.context = context;
            this.entryRepository = entryRepository;
            InitializeComponent();
        }


        /*
         * Data input section
         */

        private void txtAmount_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && e.Text != "." && e.Text != ",") 
                e.Handled = true;
        }
    }
}
