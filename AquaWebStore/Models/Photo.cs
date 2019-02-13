using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public string Path { get; set; }
        public virtual Hsuit hsuit { get; set; }
    }
}