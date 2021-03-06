﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using FullScratch.Command;
using FullScratch.Models;

namespace FullScratch.ViewModels
{
    public class CustomMenuViewModel:ViewModelBase
    {
        private ObservableCollection<Menu> _RootMenu { get; set; } = new ObservableCollection<Menu>();
        public ObservableCollection<Menu> RootMenu
        {
            get
            {
                return _RootMenu;
            }
            set
            {
                _RootMenu = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(_RootMenu));
            }
        }

        public CustomMenuViewModel()
        {
            RootMenu.Add(new Menu("File",
                                  new ObservableCollection<Menu> { new Menu("New",new NewFileCmd()),
                                                                   new Menu("Open"),
                                                                   new Menu("Save(New)"),
                                                                   new Menu("Save(OverWrite)"),
                                                                   new Menu("Quit")},
                                  new NewFileCmd()));
            RootMenu.Add(new Menu("Edit"));
            RootMenu.Add(new Menu("Find & Replace"));
            RootMenu.Add(new Menu("Help"));
            RootMenu.Add(new Menu("Version"));
        }
    }
}
