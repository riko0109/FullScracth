using FullScratch.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullScratch.ViewModels
{
    public class CustomListViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<FileInfo> _FileList { get; set; }
        public ObservableCollection<FileInfo> FileList
        {
            get
            {
                return _FileList;
            }
            set
            {
                _FileList = value;
                RaisePropertyChanged();
            }
        }

        public CustomListViewModel()
        {
            Models.Directory.SelectedChanged += FileListUpdate;
        }

        private void FileListUpdate()
        {
            try
            {
                FileList =new ObservableCollection<FileInfo>(Models.Directory.SelectedDirectory.DirectoryInfo.GetFiles());
            }
            catch
            {

            }
        }


        /// <summary>
        /// プロパティ変更通知用イベントハンドラ
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
                => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
