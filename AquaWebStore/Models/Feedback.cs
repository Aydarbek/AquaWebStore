using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string Author { get; set; }
        public DateTime PostTime { get; set; }
        public string Text { get; set; }
    }
}