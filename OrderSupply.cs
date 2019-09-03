
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class OrderSupply
    {
        [Key]
        public int orderId { get; set; }

        [Display(Name = "Order Number")]
        public string OrderNum { get; set; }

        [Display(Name = "supplier Name")]
        public string supplier { get; set; }

        [Display(Name = "supplier Email")]
        public string supplierEmail { get; set; }

        [Display(Name = "Supplier Phone")]
        public string suplyNum { get; set; }

        [Display(Name = "Number of items ordered")]
        public int itemQty { get; set; }

        [Display(Name = "Products ordered")]
        public string ProductsList { get; set; }

        [Display(Name = "Number Of Prod Ordered")]
        public int NumOfProdOrdered { get; set; }

        [Display(Name = "Ordered By")]
        public string orderedBy { get; set; }

        [Display(Name = "Total Order Cost")]
        public decimal totalOrder { get; set; }

        [Display(Name = "Date ordered")]
        public string dateOrdered { get; set; }

        [Display(Name = "Status Order")]
        public string status { get; set; }

        [Display(Name = "Is Ordered")]
        public bool isOrdered { get; set; }
        //public int ProuctsId { get; set; }
        //public virtual InventoryProduct InventoryProducts { get; set; }
        //public int SupplierId { get; set; }
        //public virtual Supplier Suppliers { get; set; }
    }
}