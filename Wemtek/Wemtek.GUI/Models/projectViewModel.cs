using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wemtek.GUI.Models
{
    public class projectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public categoryViewModel Category { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }

    }
}