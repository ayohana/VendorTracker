using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorID}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor selectedVendor = Vendor.Find(vendorID);
      return View(selectedVendor);
    }

  }
}