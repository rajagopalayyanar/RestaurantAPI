using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Models
{
    public class OrderFeedback
    {
        public string RestaurentId { get; set; }
        public string OrderID { get; set; }
        public double Ratings { get; set; }
        public string Comments { get; set; }
    }
}
