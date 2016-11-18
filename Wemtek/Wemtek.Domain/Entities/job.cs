using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class job
    {
        public int idJob { get; set; }
        public Nullable<System.DateTime> datePublication { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public Nullable<int> cat_idCategory { get; set; }
        public Nullable<int> client_idUser { get; set; }
    }
}
