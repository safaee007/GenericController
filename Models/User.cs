using GenericController.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class User: UserBasic
    {
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Moblie { get; set; }
        public long NationalCode { get; set; }
        public long RegisterDate{ get; set; }
        [NotMapped]
        public int TourCount { get; set; }
    }

    public class UserBasic: BaseModel
    {
        [Required]
        public Guid UserID { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Lastname { get; set; }
        public string Avatar { get; set; }
        public Variables.UserType UserType { get; set; }
    }
}
