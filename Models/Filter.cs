using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Filter
    {
        public int Page { get; set; } = 0;
        public string Search { get; set; } = string.Empty;
        public int Order { get; set; } = 0;
        public int User { get; set; } = 0;
    }
}
