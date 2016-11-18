using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class memberViewModel
    {
        public int id { get; set; }
        public Nullable<int> member_idUser { get; set; }
        public Nullable<int> project_id { get; set; }
        public virtual projectViewModel project { get; set; }
        public virtual userViewModel user { get; set; }
    }
}
