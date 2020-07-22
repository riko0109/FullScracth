using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FullScratch.Models.Common;
using System.IO;
using System.Windows.Input;
using FullScratch.Models.Command;

namespace FullScratch.Models
{
    class GridTabItem:TabItemBase
    {
        public GridTabItem(string header,string datapath,ControlType type):base(header,type)
        {
            this.Header = header;
            this.DataTable =new DataTableConstructor(datapath,Encoding.Default,false).Construct();
            this.TabType = type;
            this.TabID = System.Guid.NewGuid().ToString();
            this._ExecuteCmd = new LoadRowCancelCmd();

        }

  
        private DataTable _DataTable { get; set; } = new DataTable();
        public DataTable DataTable
        {
            get
            {
                return _DataTable;
            }
            set
            {
                _DataTable = value;
            }
        }

        private long _RowIndex { get; set; }
        public long RowIndex
        {
            get
            {
                return DataTable.Rows.Count;
            }
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
    }
}
