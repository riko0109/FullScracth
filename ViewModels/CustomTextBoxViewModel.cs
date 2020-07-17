using FullScratch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullScratch.ViewModels
{
    public class CustomTextBoxViewModel :ViewModelBase
    {
        /// <summary>
        /// ファイル、フォルダのフルパス
        /// </summary>
        private string _FullPath { get; set; }
        public string FullPath
        {
            get
            {
                return _FullPath;
            }
            set
            {
                _FullPath = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(_FullPath));
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CustomTextBoxViewModel()
        {
            //ツリービューの選択アイテム変更イベントを購読し発生したらTreeViewSelectedChangedを呼ぶ
            Directory.OnSelectedChanged += FullPathChanged;
            CustomListViewModel.SelectedFileChanged += FullPathChanged;
        }

        /// <summary>
        /// ツリービューの選択アイテム変更時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        private void FullPathChanged(object sender)
        {
           
            if (sender is Directory)
            {
                FullPath = ((Directory)sender).DirectoryInfo.FullName;
            }
            else if (sender is CustomListViewModel)
            {
                FullPath = ((CustomListViewModel)sender).SelectedListItem?.FullName;
            }
        }
    }
}
