using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Hsuit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Photo> photo { get; set; } = new List<Photo>();
    }
}