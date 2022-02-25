using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Models
{
    public class HomeViewModel
    {
        public List<Banner> Banners { get; set; }

        public List<Work> Works { get; set; }

        public List<News> News { get; set; }

        public Testimonials Testimonials { get; set; }
        public List<Features> Features { get; set; }

    }
}
