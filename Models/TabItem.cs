using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }
        }

        public TabItem(string header,string contents)
        {
            this.Header = header;
            this.Contents = contents;
        }


        public static List<Menu> ContextMenu { get; set; }
            = new List<Menu> { new Menu("閉じる"),
                               new Menu("ooo")};
    }
}
