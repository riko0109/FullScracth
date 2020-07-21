using FullScratch.Models.Common;
using FullScratch.ViewModels;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using static FullScratch.Models.TabItemBase;

namespace FullScratch.Models.Command
{
    public class OpenFileCmd : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            using (var Opener = new FileOpener(Encoding.Default, ControlType.CSV))
            {
                Opener.OpenFile();
            }
        }
    }
}
