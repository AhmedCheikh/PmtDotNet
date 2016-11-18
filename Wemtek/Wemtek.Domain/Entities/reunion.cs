using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class reunion
    {
        public int IdR { get; set; }
        public Nullable<System.DateTime> DateR { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string name { get; set; }
    }
}
