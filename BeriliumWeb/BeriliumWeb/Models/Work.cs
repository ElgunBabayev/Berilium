using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Models
{
    
    
        public class Work : BaseEntity
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Blur { get; set; }
        }
    
}
