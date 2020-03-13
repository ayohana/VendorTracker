using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description");
      Assert.AreEqual(typeof(newVendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test description");

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Grandma Suzie sells coffee and yummy sweets.";
      Vendor newVendor = new Vendor("test name", description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe", "Grandma Suzie sells coffee and yummy sweets.");
      Vendor newVendor2 = new Vendor("Pierre's Bakery", "Pierre sells amazing organic French baguettes.");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
  
      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetID_ReturnsVendorID_Int()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe", "Grandma Suzie sells coffee and yummy sweets.");
      int result = newVendor.ID;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe", "Grandma Suzie sells coffee and yummy sweets.");
      Vendor newVendor2 = new Vendor("Pierre's Bakery", "Pierre sells amazing organic French baguettes.");
  
      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      // Vendor newVendor1 = new Vendor("Suzie's Cafe", "Grandma Suzie sells coffee and yummy sweets.");
      // Vendor newVendor2 = new Vendor("Pierre's Bakery", "Pierre sells amazing organic French baguettes.");
      // List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
  
      // List<Vendor> result = Vendor.GetAll();

      // CollectionAssert.AreEqual(newList, result);
    }
  }
}
