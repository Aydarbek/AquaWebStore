using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class SubOrder
    { 
        [Key]
        public int SuborderId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
        public virtual Hsuit Hsuit { get; set; }

    }
}