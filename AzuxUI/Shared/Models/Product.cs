using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AzuxUI.Shared.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1,ErrorMessage ="Product name cannot be empty.")]
        public string ProductName { get; set; }

        public decimal DefaultPrice { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public decimal MaxRetailPrice { get; set; }

        [NotMapped]
        public readonly static string DatabaseName = "Products";

    }
}
