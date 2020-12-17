using System;
using System.Collections.Generic;
using System.Text;

namespace ONEUL
{
    class ListItem
    {
        public string Title { get; set; }
        public string Memo { get; set; }

        public ListItem(string title, string memo)
        {
            this.Title = title;
            this.Memo = memo;
        }

    }
}
