using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalmasBook.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } //Displays all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; } //install package 'Microsoft.AspNetCore.Mvc.ViewFeatures package
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
