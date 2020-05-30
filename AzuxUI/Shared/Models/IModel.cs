using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AzuxUI.Shared.Models
{
    public interface IModel
    {
        int Id { get; set; }
        static string DatabaseName { get; }
    }
}
