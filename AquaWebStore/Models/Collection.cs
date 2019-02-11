using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Collection
    {
        [Key]
        public int CollectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Hsuit> Hsuits { get; set; } = new List<Hsuit>();

    }
}