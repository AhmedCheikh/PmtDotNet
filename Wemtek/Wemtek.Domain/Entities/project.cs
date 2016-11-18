using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class project
    {
        public int id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Nullable<int> category_idCategory { get; set; }
    }
}
