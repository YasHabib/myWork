using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.AssetTracking;
using Microsoft.AspNetCore.Mvc;
using Presentation.AssetTracking.Models;
using Domain.AssetTracking;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace Presentation.AssetTracking.Controllers
{
    public class AssetController : Controller
    {
        //listing all current assets
        public IActionResult Index()
        {
            //Check ViewComponents/AssetsByType for list codes
            ViewBag.AssetTypes = GetAssetTypes(); //Connection to dropdown menu (for filtering)
            return View();
        }


        //Creating new asset
        public IActionResult Create()
        {
            var aType = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(aType, "Value", "Text");
            ViewBag.AssetTypeId = list; //Different then GetAssetTypes (I did not want it to show "All" on index 0 while adding new assets)
            return View();
        }


        //Saving the new asset
        [HttpPost]
        public IActionResult Create(Asset asset)
        {
            try
            {
                AssetManager.Add(asset);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        //******Filtering by asset type******///

        //**Optional** total of selected asset along with the list, (didn't work)
        //public IActionResult Total(int id)
        //{
        //    var filteredAssets = AssetManager.GetAllByAssetType(id);
        //    var result = $"Total Assets: {filteredAssets.Count}";
        //    return Content(result);
        //}

        //Dropdown, innitial index is set to "All" for the main page ONLY
        protected IEnumerable GetAssetTypes()
        {
            var types = AssetTypeManager.GetAsKeyValuePairs();
            var names = new SelectList(types, "Value", "Text");

            //setting innitial value to "All"
            var list = names.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "All",
                Value = "0"
            });
            return list;
        }
        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }


    }//End of Controller
}//End of namespace