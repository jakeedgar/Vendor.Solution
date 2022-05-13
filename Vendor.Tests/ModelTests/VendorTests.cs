using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendor.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnVendorName_String()
    {
      string vendorName = "Pierre's Bakery";
      Vendor testVendor = new Vendor(vendorName);
      string result = testVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      string name1 = "Vendor One";
      string name2 = "Vendor Two";
      Vendor testVendor1 = new Vendor(name1);
      Vendor testVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { testVendor1, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
