using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.AssetTracking
{
    [Table("Asset")]
    public class Asset
    {  
        //Id
        [Required]
        public int Id { get; set; }
        //Tag number
        [Required]
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }
        //Asset Type
        [Required]
        [Display(Name = "Asset Type")]
        public int? AssetTypeId { get; set; }
        //Manufacturer
        [Required]
        public string Manufacturer { get; set; }
        //Model
        public string Model { get; set; } //Not required
        //Description
        [Required]
        public string Description { get; set; }
        //Serial Number
        [Display(Name = "Serial Number")]
        [Required]
        public string SerialNumber { get; set; }
        //Asset type navigation property
        [Display(Name = "Asset Type")]
        public AssetType AssetType { get; set; }
    }
}
