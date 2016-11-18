using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class projectViewModel
    {
        public projectViewModel()
        {
            this.deals = new List<dealViewModel>();
            this.documents = new List<documentViewModel>();
            this.members = new List<memberViewModel>();
            this.tasks = new List<taskViewModel>();
            this.projectreviews = new List<projectreviewViewModel>();
        }

        public int id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public byte[] deal { get; set; }
        public byte[] review { get; set; }
        public Nullable<int> category_idCategory { get; set; }
        public virtual categoryViewModel category { get; set; }
        public virtual ICollection<dealViewModel> deals { get; set; }
        public virtual ICollection<documentViewModel> documents { get; set; }
        public virtual ICollection<memberViewModel> members { get; set; }
        public virtual ICollection<taskViewModel> tasks { get; set; }
        public virtual ICollection<projectreviewViewModel> projectreviews { get; set; }
    }
}
