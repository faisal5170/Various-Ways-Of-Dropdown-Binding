using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DynamicDropdownController : Controller
    {
        // GET: DynamicDropdown
        public ActionResult Index()
        {
            //Using Viewbag
            List<SelectListItem> drpList = new List<SelectListItem>();
            drpList.Add(new SelectListItem { Text = "Faisal", Value = "1" });
            drpList.Add(new SelectListItem { Text = "Irshad", Value = "1" });
            drpList.Add(new SelectListItem { Text = "Kaushik", Value = "1" });
            drpList.Add(new SelectListItem { Text = "Jaimin", Value = "1" });
            drpList.Add(new SelectListItem { Text = "Kirti", Value = "1" });
            ViewBag.DrpListViewBag = drpList;

            //Using ViewData
            List<SelectListItem> drpListViewData = new List<SelectListItem>();
            drpListViewData.Add(new SelectListItem { Text = "Faisal", Value = "1" });
            drpListViewData.Add(new SelectListItem { Text = "Irshad", Value = "1" });
            drpListViewData.Add(new SelectListItem { Text = "Kaushik", Value = "1" });
            drpListViewData.Add(new SelectListItem { Text = "Jaimin", Value = "1" });
            drpListViewData.Add(new SelectListItem { Text = "Kirti", Value = "1" });
            ViewData["Names"] = drpListViewData;

            //Using TempData
            List<SelectListItem> drpListTempData = new List<SelectListItem>();
            drpListTempData.Add(new SelectListItem { Text = "Faisal", Value = "1" });
            drpListTempData.Add(new SelectListItem { Text = "Irshad", Value = "1" });
            drpListTempData.Add(new SelectListItem { Text = "Kaushik", Value = "1" });
            drpListTempData.Add(new SelectListItem { Text = "Jaimin", Value = "1" });
            drpListTempData.Add(new SelectListItem { Text = "Kirti", Value = "1" });
            TempData["Names"] = drpListTempData;
            return View();
        }
        public ActionResult GetListData()
        {
            Context _context = new Context();
            var data = _context.Angulars.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}