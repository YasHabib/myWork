using Data.AssetTracking;
using Domain.AssetTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.AssetTracking
{
    public class AssetManager
    {
        //Display list of asset
        public static List<Asset> GetAsset()
        {
            var context = new AssetContext();
            var assets = context.Assets.Include(a => a.AssetType).ToList(); //Adding Asset Type to asset so Name of the asset type can be called
            return assets;
        }

        //Adding new asset
        public static void Add(Asset assets)
        {
            var context = new AssetContext();
            context.Assets.Add(assets);
            context.SaveChanges();
        }

        //******For Filtering****
        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetContext();
            var assets = context.Assets
                .Where(type=> type.AssetTypeId == id)
                .Include(a => a.AssetType).ToList();
            return assets;
        }
    }
}
