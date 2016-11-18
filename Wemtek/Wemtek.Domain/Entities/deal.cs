using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class deal
    {
        public int idDeal { get; set; }
        public Nullable<System.DateTime> dateDeal { get; set; }
        public int days { get; set; }
        public string description { get; set; }
        public Nullable<float> price { get; set; }
        public Nullable<int> client_idUser { get; set; }
        public Nullable<int> company_Id { get; set; }
        public Nullable<int> job_idJob { get; set; }
    }
}
