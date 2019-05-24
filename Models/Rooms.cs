using System;
using System.Collections.Generic;

namespace TreasureHunter.Models
{
  public class Room
  {
    public string Description { get; set; }
    public List<Item> Inventory { get; set; }
    public Dictionary<string, Room> Exits { get; set; }
    public string Name { get; set; }
    public bool IsLoseable { get; set; }


    public Room(string name, string description, bool isloseable)
    {
      Name = name;
      Description = description;
      IsLoseable = isloseable;
      Inventory = new List<Item>();
      Exits = new Dictionary<string, Room>();

    }
  }
}