using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class User: BaseModel
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
