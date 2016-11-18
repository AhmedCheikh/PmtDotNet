using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class projectreviewViewModel
    {
        public int idReview { get; set; }
        public Nullable<System.DateTime> dateReview { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public Nullable<int> client_idUser { get; set; }
        public Nullable<int> project_id { get; set; }
        public virtual projectViewModel project { get; set; }
        public virtual userViewModel user { get; set; }
    }
}
