using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

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

    public Order(string title, string description, int quantity, int price, DateTime deliveryDate)
    {
      Title = title;
      Description = description;
      Quantity = quantity;
      Price = price;
      DeliveryDate = deliveryDate;
    }

    public Order(int id, string title, string description, int quantity, int price, DateTime deliveryDate)
    {
      ID = id;
      Title = title;
      Description = description;
      Quantity = quantity;
      Price = price;
      DeliveryDate = deliveryDate;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM orders;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static List<Order> GetAll()
    {
      List<Order> allOrders = new List<Order> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM orders;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int orderID = rdr.GetInt32(0);
        string orderTitle = rdr.GetString(1);
        string orderDesc = rdr.GetString(2);
        int orderQuantity = rdr.GetInt32(3);
        int orderPrice = rdr.GetInt32(4);
        DateTime orderDeliveryDate = rdr.GetDateTime(5);
        Order newOrder = new Order(orderID, orderTitle, orderDesc, orderQuantity, orderPrice, orderDeliveryDate);
        allOrders.Add(newOrder);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allOrders;
    }

    public static Order Find(int searchID)
    {
      return new Order("placeholder title", "placeholder desc", 1, 1, new DateTime(2020, 4, 1));
    }
    
  }
}