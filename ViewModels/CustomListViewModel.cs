using FullScratch.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using static FullScratch.Models.Directory;

namespace FullScratch.ViewModels
{
    public class CustomListViewModel : ViewModelBase
    {

        /// <summary>
        /// FileListに表示するオブジェクト
        /// </summary>
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

        private FileInfo _SelectedListItem { get; set; }
        public FileInfo SelectedListItem
        {
            get
            {
                return _SelectedListItem;
            }
            set
            {
                _SelectedListItem = value;
                SelectedFileChanged(this);
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        public delegate void SelectedChangedEventHandler(object sender);
        public　static event SelectedChangedEventHandler SelectedFileChanged;

        public CustomListViewModel()
        {
            Models.Directory.OnSelectedChanged += FileListUpdate;
        }

        private void FileListUpdate(object sender)
        {
            try
            {
                FileList = new ObservableCollection<FileInfo>(((Models.Directory)sender).DirectoryInfo.GetFiles());
            }
            catch
            {
            }
        }



    }
}
