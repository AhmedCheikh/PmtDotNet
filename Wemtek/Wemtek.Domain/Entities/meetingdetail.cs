using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class meetingdetail
    {
        public int id { get; set; }
        public Nullable<int> member_idUser { get; set; }
        public Nullable<int> reunion_IdR { get; set; }
    }
}
