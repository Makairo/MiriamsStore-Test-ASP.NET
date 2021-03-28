using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiriamsStoreSln.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        [Column(TypeName ="decimal(8, 2)")]
        public decimal ProductPrice { get; set; }

    }
}
