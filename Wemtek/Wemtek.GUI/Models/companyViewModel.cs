using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class companyViewModel
    {
        public companyViewModel()
        {
            this.users = new List<userViewModel>();
            this.deals = new List<dealViewModel>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public virtual ICollection<userViewModel> users { get; set; }
        public virtual ICollection<dealViewModel> deals { get; set; }
    }
}
