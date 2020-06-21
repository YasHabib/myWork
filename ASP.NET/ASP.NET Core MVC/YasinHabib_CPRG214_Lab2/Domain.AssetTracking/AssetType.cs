using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.AssetTracking
{
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter the type of asset")]
        public string Name { get; set; }
        public ICollection<Asset> Asset { get; set; }
    }
}
