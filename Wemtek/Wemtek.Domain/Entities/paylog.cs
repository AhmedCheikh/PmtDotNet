using System;
using System.Collections.Generic;

namespace Wemtek.Domain.Entities
{
    public partial class paylog
    {
        public int idPay { get; set; }
        public int progressValue { get; set; }
        public int unitPrice { get; set; }
        public Nullable<int> deal_idDeal { get; set; }
    }
}
