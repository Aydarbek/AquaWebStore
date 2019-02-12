using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Status { get; set; }
        public int SubTotal { get; set; }
        public int Total { get; set; }


        public string Name { get; set; }
        public string Address { get; set; }
        public string EMail {get;set;}
        public string Phone { get; set; }

        public virtual ICollection<SubOrder> SubOrders { get; set; } = new List<SubOrder>();
        public virtual PromoCode PromoCode { get; set; }
    }
}