using System;
using SQLite;

namespace ONEUL.Model
{
    public class ListItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Memo { get; set; }
        public DateTime Time { get; set; }
    }
}
