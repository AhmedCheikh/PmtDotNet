using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class roleViewModel
    {
        public roleViewModel()
        {
            this.users = new List<userViewModel>();
        }

        public int RoleId { get; set; }
        public string Role1 { get; set; }
        public virtual ICollection<userViewModel> users { get; set; }
    }
}
