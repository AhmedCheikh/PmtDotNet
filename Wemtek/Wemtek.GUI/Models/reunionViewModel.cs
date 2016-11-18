using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class reunionViewModel
    {
        public reunionViewModel()
        {
            this.meetingdetails = new List<meetingdetailViewModel>();
        }

        public int IdR { get; set; }
        public Nullable<System.DateTime> DateR { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string name { get; set; }
        public virtual ICollection<meetingdetailViewModel> meetingdetails { get; set; }
    }
}
