using FullScratch.Models.Command;
using FullScratch.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullScratch.Models
{
    public class TabItem
    {
        /// <summary>
        /// ヘッダーに表示される文字列
        /// </summary>
        public string Header { get; private set; }

        /// <summary>
        /// タブコントロールに表示される文字列
        /// </summary>
        private string _Contents { get; set; }
        public string Contents
        {
            get
            {
                return _Contents;
            }
            set
            {
                _Contents = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(_Contents));
            }
        }

        /// <summary>
        /// TabItemのアイデンティティ
        /// </summary>
        private string _TabID { get; set; }
        public string TabID
        {
            get
            {
                return _TabID;
            }
            set
            {
                _TabID = value;
            }
        }

        public TabItem(string header,string contents)
        {
            this.Header = header;
            this.Contents = contents; 
            this.ExecuteCmd = new TabCloseCmd();
            this.TabID = System.Guid.NewGuid().ToString();
            
        }

        private ICommand _ExecuteCmd { get; set; }
        public ICommand ExecuteCmd
        {
            get
            {
                return _ExecuteCmd;
            }
            set
            {
                _ExecuteCmd = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
