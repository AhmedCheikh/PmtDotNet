using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class skillViewModel
    {
        public int idSkills { get; set; }
        public string name { get; set; }
        public Nullable<int> job_idJob { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual jobViewModel job { get; set; }
        public virtual userViewModel user { get; set; }
    }
}
