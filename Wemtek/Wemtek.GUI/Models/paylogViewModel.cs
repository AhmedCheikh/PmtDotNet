using System;
using System.Collections.Generic;

namespace Wemtek.GUI.Models
{
    public partial class paylogViewModel
    {
        public int idPay { get; set; }
        public int progressValue { get; set; }
        public int unitPrice { get; set; }
        public Nullable<int> deal_idDeal { get; set; }
        public virtual dealViewModel deal { get; set; }
    }
}
