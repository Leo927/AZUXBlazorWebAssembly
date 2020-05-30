using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZUXUI.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="CategoryName cannot be more than 20 characters.")]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
    }
}
