using System;
using System.Collections.Generic;
using System.Text;

namespace ONEUL
{
    class ListItem
    {
        public string Title { get; set; }
        public int Time { get; set; }

        public ListItem(string title, int time)
        {
            this.Title = title;
            this.Time = time;
        }

    }
}
