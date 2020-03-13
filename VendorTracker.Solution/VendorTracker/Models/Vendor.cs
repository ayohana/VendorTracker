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
      Name = name;
      Description = description;
      Orders = new List<Order> { };
      _allVendors.Add(this);
      ID = _allVendors.Count;
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _allVendors;
    }

    public static Vendor Find(int searchID)
    {
      return _allVendors[searchID-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}