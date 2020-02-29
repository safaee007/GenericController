using GenericController.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Tour: BaseModel
    {
        [Required]
        public Guid TourID { get; set; }
        public string Title { get; set; }
        public Variables.TourType Type { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public string LocationMove { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public int Gift { get; set; }
        public Guid UserOwner { get; set; }
        public long CreateDate { get; set; }
        [NotMapped]
        public List<UserBasic> Users { get; set; }
        [NotMapped]
        public List<UserBasic> Leaders { get; set; }
    }
}
