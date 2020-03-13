using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {

    public string Name { get; set; }
    public string Description { get; set; }
    public int ID { get; }
    private static List<Vendor> _allVendors = new List<Vendor> { };
    public List<Order> Orders { get; set; } 

    public Vendor(string name, string description)
    {
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {

    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }

    public static Vendor Find(int id)
    {
      Vendor found = new Vendor("test", "test");
      return found;
    }

    public void AddOrder(Order order)
    {

    }

  }
}