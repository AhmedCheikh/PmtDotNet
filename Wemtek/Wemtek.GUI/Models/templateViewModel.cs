using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class templateViewModel
    {
        public templateViewModel()
        {
            this.users = new List<userViewModel>();
        }

        public int idTemplate { get; set; }
        public string Path { get; set; }
        public virtual ICollection<userViewModel> users { get; set; }
    }
}
