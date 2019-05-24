using System;

namespace TreasureHunter.Models
{
  public class Item
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public Item(string item, string description)
    {
      Name = item;
      Description = description;


    }



  }


}