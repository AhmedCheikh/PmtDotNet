using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class meetingdetailViewModel
    {
        public int id { get; set; }
        public Nullable<int> member_idUser { get; set; }
        public Nullable<int> reunion_IdR { get; set; }
        public virtual reunionViewModel reunion { get; set; }
        public virtual userViewModel user { get; set; }
    }
}
