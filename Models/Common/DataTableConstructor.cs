using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullScratch.Models.Common
{
    class DataTableConstructor
    {
        public DataTableConstructor(string data)
        {
            this.StringData = data;
        }

        private string _StringData { get; set; }
        public string StringData
        {
            get
            {
                return _StringData;
            }
            set
            {
                _StringData = value;
            }
        }

        public DataTable Construct()
        {
            var temptable = new DataTable();
            using (var StringReader = new StringReader(this.StringData))
            {
                var Line = StringReader.ReadLine();
                var SeparaterCount = Line.Length - Line.Replace(",", "").Length;
            }
        }
    }
}
