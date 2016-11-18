using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class dealViewModel
    {
        public dealViewModel()
        {
            this.paylogs = new List<paylogViewModel>();
        }

        public int idDeal { get; set; }
        public Nullable<System.DateTime> dateDeal { get; set; }
        public int days { get; set; }
        public string description { get; set; }
        public Nullable<float> price { get; set; }
        public Nullable<int> client_idUser { get; set; }
        public Nullable<int> company_Id { get; set; }
        public Nullable<int> project_id { get; set; }
        public virtual companyViewModel company { get; set; }
        public virtual ICollection<paylogViewModel> paylogs { get; set; }
        public virtual projectViewModel project { get; set; }
        public virtual userViewModel user { get; set; }
    }
}
