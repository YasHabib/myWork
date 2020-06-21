using Data.AssetTracking;
using Domain.AssetTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.AssetTracking
{
    public class AssetTypeManager
    {
        //For dropdown
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetContext();
            var types = context.AssetTypes.Select(aT => new
            {
                Value = aT.Id, //Dropdown display value
                Text = aT.Name //Dropdown display text
            }).ToList();
            return types;
        }
        //Adding new asset type
        public static void Add(AssetType assettype)
        {
            var context = new AssetContext();
            context.AssetTypes.Add(assettype);
            context.SaveChanges();
        }
    }
}
