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
      Title = title;
      Description = description;
      Quantity = quantity;
      Price = price;
      DeliveryDate = deliveryDate;
      _allOrders.Add(this);
      ID = _allOrders.Count;
    }

    public static void ClearAll()
    {
      _allOrders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _allOrders;
    }

    public static Order Find(int searchID)
    {
      return _allOrders[searchID-1];
    }
  }
}