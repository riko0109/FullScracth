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
            var TabViewModel = new CustomTabViewModel();
            TabViewModel.TabAdd(new Models.TabItem("New", "a"));
            TabViewModel.TabAdd(new Models.TabItem("Grid", "a",Models.TabItem.ControlType.CSV));

        }
    }
}
