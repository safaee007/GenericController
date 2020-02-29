using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Utilities
{
    public class Variables
    {
        public enum TourType
        {
            None = 0,
            Daily = 1,
            MultiDay = 2,
            City = 3,
            Country = 4
        }
        public enum UserType
        {
            None = 0,
            HamSafar = 1,
            Leader = 2
        }
    }
}
