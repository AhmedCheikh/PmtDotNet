using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class jobViewModel
    {
        public jobViewModel()
        {
            this.skills = new List<skillViewModel>();
        }

        public int idJob { get; set; }
        public Nullable<System.DateTime> datePublication { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public Nullable<int> cat_idCategory { get; set; }
        public virtual categoryViewModel category { get; set; }
        public virtual ICollection<skillViewModel> skills { get; set; }
    }
}
