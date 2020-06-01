using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AzuxUI.Shared.Models
{
    public class Category : IModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage ="CategoryName cannot be more than 20 characters.")]
        [MinLength(1,ErrorMessage ="CategoryName has to be at least 1 character long.")]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [NotMapped]
        public static string DatabaseName { get => "Categories"; }


    }
}
