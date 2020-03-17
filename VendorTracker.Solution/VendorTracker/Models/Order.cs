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
    public int ID { get; set; }

    public Order(string title)
    {
      Title = title;
    }

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

    public override bool Equals(System.Object otherOrder)
    {
      if (!(otherOrder is Order))
      {
        return false;
      }
      else
      {
        Order newOrder = (Order) otherOrder;
        bool idEquality = (this.ID == newOrder.ID);
        bool titleEquality = (this.Title == newOrder.Title);
        bool descriptionEquality = (this.Description == newOrder.Description);
        bool quantityEquality = (this.Quantity == newOrder.Quantity);
        bool priceEquality = (this.Price == newOrder.Price);
        bool deliveryDateEquality = (this.DeliveryDate == newOrder.DeliveryDate);
        return (idEquality && titleEquality && descriptionEquality && quantityEquality && priceEquality && deliveryDateEquality);
      }
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

      cmd.CommandText = @"INSERT INTO orders (title, description, quantity, price, deliveryDate) VALUES (@OrderTitle, @OrderDescription, @OrderQuantity, @OrderPrice, @OrderDeliveryDate);";

      MySqlParameter title = new MySqlParameter();
      title.ParameterName = "@OrderTitle";
      title.Value = this.Title;
      cmd.Parameters.Add(title);
      MySqlParameter description = new MySqlParameter();
      description.ParameterName = "@OrderDescription";
      description.Value = this.Description;
      cmd.Parameters.Add(description);
      MySqlParameter quantity = new MySqlParameter();
      quantity.ParameterName = "@OrderQuantity";
      quantity.Value = this.Quantity;
      cmd.Parameters.Add(quantity);
      MySqlParameter price = new MySqlParameter();
      price.ParameterName = "@OrderPrice";
      price.Value = this.Price;
      cmd.Parameters.Add(price);
      MySqlParameter deliveryDate = new MySqlParameter();
      deliveryDate.ParameterName = "@OrderDeliveryDate";
      deliveryDate.Value = this.DeliveryDate;
      cmd.Parameters.Add(deliveryDate);
      cmd.ExecuteNonQuery();

      ID = (int) cmd.LastInsertedId;

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
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