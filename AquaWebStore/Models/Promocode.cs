using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class PromoCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Discount { get; set; }
    }
}