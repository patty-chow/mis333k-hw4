using System;
using System.ComponentModel.DataAnnotations;

namespace Chow_Patty_HW4.Models

{
    public enum ProductType
    {
        [Display(Name = "New Hardback")] New_Hardback,
        [Display(Name = "Used Hardback")] Used_Hardback,
        [Display(Name = "New Paperback")] New_Papaerback,
        [Display(Name = "Used Paperback")] Used_Paperback,
        [Display(Name = "Other")] Other
    }

    public class Product
    {
        [Display(Name = "Product ID")]
        public Int32 ProductID { get; set; }

        //s billno = billno + 1;


        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Product name is required")]
        public String ProductName { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Product price is required")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal ProductPrice { get; set; }

        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }

    }
}