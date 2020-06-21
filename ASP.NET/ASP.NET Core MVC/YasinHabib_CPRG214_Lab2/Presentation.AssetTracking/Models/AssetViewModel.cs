using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.AssetTracking.Models
{
    public class AssetViewModel
    {
        [Required]
        public int? Id { get; set; }
        public string Model { get; set; } //Not required
        [Required]
        public string Manufacturer { get; set; }
        [Display(Name = "Asset Type")]
        public int? AssetTypeId { get; set; }

        [Required]
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
        [Display(Name = "Asset Type")]
        public string AssetType { get; set; }
    }
}
