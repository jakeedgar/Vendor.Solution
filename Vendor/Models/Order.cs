using System.Collections.Generic;

namespace BakeryVendor.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Orders> _instances = new List<Orders> { };

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}