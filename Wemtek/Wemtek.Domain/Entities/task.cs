using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class task
    {
        public int id { get; set; }
        public int complexity { get; set; }
        public Nullable<System.DateTime> deadLine { get; set; }
        public double duration { get; set; }
        public string etat { get; set; }
        public Nullable<int> assignedTo_idUser { get; set; }
        public Nullable<int> projet_id { get; set; }
    }
}
