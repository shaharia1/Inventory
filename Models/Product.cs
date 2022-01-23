using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductCode { get; set; }

        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        public int? TypeId { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}