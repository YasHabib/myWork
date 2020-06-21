using BLL.AssetTracking;
using Domain.AssetTracking;
using Microsoft.AspNetCore.Mvc;
using Presentation.AssetTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.AssetTracking.ViewComponents
{
    public class AssetsByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            List<Asset> types = null;
            if (id == 0)
            {
                types = AssetManager.GetAsset();
            }
            else
            {
                types = AssetManager.GetAllByAssetType(id);
            }
            var assets = types.Select(a => new AssetViewModel
            {

                Description = a.Description,
                AssetType = a.AssetType.Name,
                TagNumber = a.TagNumber,
                SerialNumber = a.SerialNumber

            }).ToList();

            return View(assets);
        }
    }
}
