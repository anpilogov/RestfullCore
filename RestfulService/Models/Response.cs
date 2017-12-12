using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulService.Models
{
    public class Response
    {
        public int[] Categories { get; set; }
        public string[] Names { get; set; }
        public string Text { get; set; }
    }
}
