﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MiriamsStoreSln.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public string ProductDesc { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,
        ErrorMessage = "Please enter a positive price")]
        public decimal ProductPrice { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public string Category {get; set;}

    }
}
