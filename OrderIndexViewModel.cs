using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class OrderIndexViewModel
    {
        public List<OrderTrack> Pending { get; set; }
        public List<OrderTrack> OnOurWarehouse { get; set; }
        public List<OrderTrack> OnItsWay { get; set; }
        public List<OrderTrack> Delivered { get; set; }
        public List<OrderTrack> cancelledOrders { get; set; }
        public List<OrderTrack> orders { get; set; }
    }
}