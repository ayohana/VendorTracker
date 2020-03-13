using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {

    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int ID { get; }
    private static List<Order> _allOrders = new List<Order> { };

    public Order(string title, string description, int quantity, int price, DateTime deliveryDate)
    {
      
    }

    public static void ClearAll()
    {

    }

    public static List<Order> GetAll()
    {
      return _allOrders;
    }

    public static Order Find(int id)
    {
      Order orderFound = new Order("test", "test", 1, 1, new DateTime(2020, 1, 1));
      return orderFound;
    }
  }
}