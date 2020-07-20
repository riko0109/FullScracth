using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScratch.Models.Common
{
    class FileOpener:IDisposable
    {
        OpenFileDialog FileDialog; 

        public FileOpener()
        {
            FileDialog = new OpenFileDialog();
        }

        public void OpenFile()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
