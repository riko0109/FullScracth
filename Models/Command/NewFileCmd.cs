using FullScratch.ViewModels;
using FullScratch.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FullScratch.Command
{
    class NewFileCmd : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CustomTabViewModel.Tabs.Add(new Models.TabItem("New", string.Empty));
        }
    }
}
