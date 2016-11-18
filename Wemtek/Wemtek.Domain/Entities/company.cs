using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class company
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public Nullable<int> tempalte_idTemplate { get; set; }
    }
}
