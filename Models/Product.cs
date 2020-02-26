using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Product: BaseModel
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
