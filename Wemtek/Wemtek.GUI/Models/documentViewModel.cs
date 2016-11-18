using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class documentViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int numberDownloading { get; set; }
        public string path { get; set; }
        public Nullable<int> projet_id { get; set; }
        public virtual projectViewModel project { get; set; }
    }
}
