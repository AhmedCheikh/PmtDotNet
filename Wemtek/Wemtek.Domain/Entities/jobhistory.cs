using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class jobhistory
    {
        public int idHistory { get; set; }
        public Nullable<int> company_Id { get; set; }
        public Nullable<int> jobs_idJob { get; set; }
    }
}
