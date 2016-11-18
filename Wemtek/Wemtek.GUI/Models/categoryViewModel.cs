using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class categoryViewModel
    {
        public categoryViewModel()
        {
            this.projects = new List<projectViewModel>();
            this.jobs = new List<jobViewModel>();
        }

        public int idCategory { get; set; }
        public string name { get; set; }
        public virtual ICollection<projectViewModel> projects { get; set; }
        public virtual ICollection<jobViewModel> jobs { get; set; }
    }
}
