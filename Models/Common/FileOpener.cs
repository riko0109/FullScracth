using FullScratch.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static FullScratch.Models.TabItemBase;

namespace FullScratch.Models.Common
{
    class FileOpener:IDisposable
    {

        public FileOpener(Encoding enc,Models.TabItemBase.ControlType controlType)
        {
            this.TabViewModel = new CustomTabViewModel();
            this.EncodingType = enc;
            this.ControlType = controlType;
        }

        private CustomTabViewModel TabViewModel;

        private Encoding EncodingType { get; set; }
        private Models.TabItemBase.ControlType ControlType { get; set; }

        public void OpenFile()
        {
            System.Windows.Forms.OpenFileDialog Dialog = new System.Windows.Forms.OpenFileDialog();

           

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader Reader = new StreamReader(Dialog.FileName, this.EncodingType))
                {
                    var TabViewModel = new CustomTabViewModel();
                    if (Path.GetExtension(Dialog.FileName) == ".csv")
                    {
                        TabViewModel.TabAdd(new Models.GridTabItem(Path.GetFileName(Dialog.FileName),Dialog.FileName,this.ControlType));
                    }
                    else
                    {
                        TabViewModel.TabAdd(new Models.TextTabItem(Path.GetFileName(Dialog.FileName), Reader.ReadToEnd(),this.ControlType));
                    }

                };
               
            }
        }

        public void Dispose()
        {
            TabViewModel = null;
        }

    }
}
