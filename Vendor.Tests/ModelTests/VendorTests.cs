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

    public void SetVendorName_ReturnCorrectName_String()
    {
      string vendorName = "old name";
      Vendor testVendor = new Vendor(vendorName);

      string updatedVendorName = "New Vendor Name";
      testVendor.VendorName = updatedVendorName;
      string result = testVendor.VendorName;

      Assert.AreEqual(updatedVendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Vendor One";
      string vendorName2 = "Vendor Two";
      Vendor testVendor1 = new Vendor(vendorName1);
      Vendor testVendor2 = new Vendor(vendorName2);
      List<Vendor> newList = new List<Vendor> { testVendor1, testVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName1 = "Vendor One";
      string vendorName2 = "Vendor Two";
      Vendor testVendor1 = new Vendor(vendorName1);
      Vendor testVendor2 = new Vendor(vendorName2);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
      
    }
  }
}
