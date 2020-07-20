using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FullScratch.Models.Common;

namespace FullScratch.Models
{
    class GridTabItem:TabItemBase
    {
        public GridTabItem(string header,string data,ControlType type):base(header,type)
        {
            this.Header = header;
            this.DataTable =new DataTableConstructor(data).TableCreate;
            this.TabType = type;
            this.TabID = System.Guid.NewGuid().ToString();

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
    }
}
