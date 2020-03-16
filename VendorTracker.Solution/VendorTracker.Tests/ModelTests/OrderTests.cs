using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    public OrderTests()
    {
      // Created to override our config set in Startup.cs to ensure connection to our test database
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=vendor_tracker_database_test";
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);

      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);
      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);
      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);
      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      int result = newOrder.Quantity;

      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);
      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDeliveryDate_ReturnsDeliveryDate_DateTime()
    {
      string title = "One-time purchase";
      string description = "croissants";
      int quantity = 20;
      int price = 40;
      DateTime deliveryDate = new DateTime(2020, 5, 15);
      Order newOrder = new Order(title, description, quantity, price, deliveryDate);

      DateTime result = newOrder.DeliveryDate;

      Assert.AreEqual(deliveryDate, result);
    }

    [TestMethod]
    public void GetID_ReturnsOrderID_Int()
    {
      string title1 = "One-time purchase";
      string description1 = "croissants";
      int quantity1 = 20;
      int price1 = 40;
      DateTime deliveryDate1 = new DateTime(2020, 5, 15);
      Order newOrder1 = new Order(title1, description1, quantity1, price1, deliveryDate1);

      int result = newOrder1.ID;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string title1 = "One-time purchase";
      string description1 = "croissants";
      int quantity1 = 20;
      int price1 = 40;
      DateTime deliveryDate1 = new DateTime(2020, 5, 15);
      string title2 = "Weekly purchase";
      string description2 = "macarons";
      int quantity2 = 40;
      int price2 = 60;
      DateTime deliveryDate2 = new DateTime(2020, 4, 14);
      Order newOrder1 = new Order(title1, description1, quantity1, price1, deliveryDate1);
      Order newOrder2 = new Order(title2, description2, quantity2, price2, deliveryDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "One-time purchase";
      string description1 = "croissants";
      int quantity1 = 20;
      int price1 = 40;
      DateTime deliveryDate1 = new DateTime(2020, 5, 15);
      string title2 = "Weekly purchase";
      string description2 = "macarons";
      int quantity2 = 40;
      int price2 = 60;
      DateTime deliveryDate2 = new DateTime(2020, 4, 14);
      Order newOrder1 = new Order(title1, description1, quantity1, price1, deliveryDate1);
      Order newOrder2 = new Order(title2, description2, quantity2, price2, deliveryDate2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}
