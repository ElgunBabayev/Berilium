using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Models
{
    public class Features :BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
    }
}
