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

    [HttpGet("/vendors/{vendorID}/orders/{orderID}")]
    public ActionResult Show(int vendorID, int orderID)
    {
      Order selectedOrder = Order.Find(orderID);
      Vendor selectedVendor = Vendor.Find(vendorID);
      Dictionary<string, object> model = new Dictionary<string, object> ();
      model.Add("vendor", selectedVendor);
      model.Add("orders", selectedOrder);
      return View(model);
    }

  }
}