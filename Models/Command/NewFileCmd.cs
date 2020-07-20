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
            TabViewModel.TabAdd(new Models.TextTabItem("New","TextTabItem",Models.TabItemBase.ControlType.Text));
            TabViewModel.TabAdd(new Models.GridTabItem("New", @"C:\Users\Administrator\Desktop\csv_kanto\kanto.csv", Models.TabItemBase.ControlType.CSV));
            TabViewModel.TabAdd(new Models.ImageTabItem("New", Models.TabItemBase.ControlType.Image, @"C:\Users\Administrator\Desktop\58f3b1ada773b6b6206db315610ede90-1000x999.jpg"));

        }
    }
}
