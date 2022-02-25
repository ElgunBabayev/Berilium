using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Models
{
    public class Testimonials :BaseEntity
    {
        public string UpText { get; set; }
        public string UpWriter { get; set; }
        public string DownText { get; set; }
        public string DownWriter { get; set; }

    }
}
