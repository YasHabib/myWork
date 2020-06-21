using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.AssetTracking;
using Domain.AssetTracking;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.AssetTracking.Controllers
{
    public class AssetTypeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AssetType assetType)
        {
            try
            {
                AssetTypeManager.Add(assetType);
                return RedirectToAction("Create", "Asset");
            }
            catch
            {
                return View();
            }
        }
    }
}