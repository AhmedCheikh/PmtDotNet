using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wemtek.GUI.Models
{
    public class TaskModels
    {
        public int Id { get; set; }
        public int Complexity { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }
        public double Duration { get; set; }
        public string Etat { get; set; }

    }
}