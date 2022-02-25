using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeriliumWeb.Models
{
    public class News :BaseEntity
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
       

        
    }
}
