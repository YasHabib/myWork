using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.AssetTracking.Models
{
    public class AssetTypeViewModel
    {
        //public int? Id { get; set; }
        //Name
        [Display(Name = "Enter the type of asset")]
        [Required]
        public string Name { get; set; }
    }
}
