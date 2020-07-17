using FullScratch.Command;
using FullScratch.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FullScratch.ViewModels
{
    public class CustomTabViewModel:ViewModelBase
    {
        /// <summary>
        /// タブアイテムを保持するコレクション
        /// </summary>
        private static ObservableCollection<TabItem> _Tabs { get; set; } = new ObservableCollection<TabItem>();
        public static ObservableCollection<TabItem> Tabs
        {
            get
            {
                return _Tabs;
            }
            set
            {
                _Tabs = value;
            }
        }

        public CustomTabViewModel()
        {
            Tabs.Add(new TabItem("New", string.Empty));
        }

        private List<Menu> _ContextMenu { get; set; }
        public List<Menu> ContextMenu
        {
            get
            {
                return TabItem.ContextMenu;
            }
            set
            {
                TabItem.ContextMenu = value;
            }
        }

    }
}
