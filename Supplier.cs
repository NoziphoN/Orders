using GateBoys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GateBoys.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int supplierid { get; set; }

        //[ForeignKey("inventoryid")]
        //public Inventory Inventory { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Supplier Name")]
        public string supplierName { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string supplierNumber { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string supplierEmail { get; set; }


        //[DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string supplierLocation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Type Of Supply")]
        public string supplytype { get; set; }

        [Display(Name = "Date Registered")]
        public string dateRegistered { get; set; }

        //[Display(Name = "Country")]
        //public string country { get; set; }
        //[Display(Name = "Street Number")]
        //public string street_number { get; set; }


        //[Display(Name = "Street Name")]
        //public string route { get; set; }

        //[Display(Name = "Province")]
        //public string administrative_area_level_1 { get; set; }


        //[Display(Name = "City")]
        //public string locality { get; set; }

        //[Display(Name = "Code")]
        //public string postal_code { get; set; }

        //public string adress { get; set; }

        //public string addressCMBN()
        //{
        //    string ad = (country + " " + street_number + " " + route + " " + administrative_area_level_1 + " " + locality + " " + postal_code);
        //    return ad;
        //}

        public Supplier()
        {
            this.InventoryProducts = new HashSet<InventoryProduct>();
            this.AdminOrders = new HashSet<AdminOrder>();
        }
        
        public virtual ICollection<AdminOrder> AdminOrders { get; set; }

        public ICollection<InventoryProduct> InventoryProducts { get; set; }
    

}
}