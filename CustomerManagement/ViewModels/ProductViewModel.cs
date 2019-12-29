using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        [Display(Name = "Ten")]
        public string Name { get; set; }
        public string ProductViewName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        [Display(Name="Category")]
        public Guid CategoryId { get; set; }

        [Display(Name = "Category")]
        public Category Category { get; set; }

        public string CategoryName { get; set; }
        public List<SelectListItem> CategorySelections { get; set; }
    }
}
