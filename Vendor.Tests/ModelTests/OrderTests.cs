using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendor.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "bread";
      int price = 1;

      Order testOrder = new Order(description, price);
      string result = testOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "some bread";
      int price = 1;
      Order testOrder = new Order(description, price);

      string updatedDescription = "some pastries";
      testOrder.Description = updatedDescription;
      string result = testOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      string description = "some bread";
      int price = 1;
      Order testOrder = new Order(description, price);

      int updatedPrice = 2;
      testOrder.Price = updatedPrice;
      int result = testOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> testOrder = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(testOrder, result);
    }

    public void GetAll_ReturnsOrders_OrderList()
    {
      string description1 = "some bread";
      int price1 = 1;
      string description2 = "some pastries";
      int price2 = 3;
      Order testOrder1 = new Order(description1, price1);
      Order testOrder2 = new Order(description2, price2);
      List<Order> newList = new List<Order> { testOrder1, testOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description1 = "some bread";
      int price1 = 1;
      string description2 = "some pastries";
      int price2 = 2;
      Order testOrder1 = new Order(description1, price1);
      Order testOrder2 = new Order(description2, price2);

      Order result = Order.Find(2);
      Assert.AreEqual(testOrder2, result);
    }
    }
}