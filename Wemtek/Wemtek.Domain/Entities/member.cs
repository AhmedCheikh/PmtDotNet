using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class member
    {
        public int id { get; set; }
        public Nullable<int> member_idUser { get; set; }
        public Nullable<int> project_id { get; set; }
    }
}
