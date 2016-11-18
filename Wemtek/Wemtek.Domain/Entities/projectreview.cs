using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class projectreview
    {
        public int idReview { get; set; }
        public Nullable<System.DateTime> dateReview { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public Nullable<int> client_idUser { get; set; }
        public Nullable<int> project_id { get; set; }
    }
}
