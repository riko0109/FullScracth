using FullScratch.Models;
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
            TabViewModel.TabAdd(new Models.TextTabItem("New",string.Empty,Models.TabItemBase.ControlType.Text));
            TabViewModel.TabAdd(new Models.ImageTabItem("New",TabItemBase.ControlType.Image, @"C:\Users\H0882\source\repos\FullScratch\Resource\cat00010.jpg"));

        }
    }
}
