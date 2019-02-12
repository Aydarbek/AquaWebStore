using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Path { get; set; }
        public virtual Hsuit hsuit { get; set; }
    }
}