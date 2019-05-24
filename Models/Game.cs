using System;

namespace TreasureHunter.Models
{
  public class Game
  {
    public Player MyPlayer { get; set; }
    public Room CurrentRooms { get; set; }

    public Item ItemName { get; set; }

    public void GameSetup()
    {
      Room TaxationStation = new Room("Taxation Station", "You walk into a room, the sound of fingers rhythmically beating typewriters clouding out all sounds of you walking, suddenly.....silence.  You are late on your taxes sir, you have 13 days to pay, you notice there's only one way into the room and the workers are chained to the tables, you notice behind them there's an open door", false);
      Room HeavensGate = new Room("Heavens Gate", "A bright white room lights up in front of you.  In the middle of the room is a golden key and a beautifully endowed bowl filled with a purple substance you believe is Kool Aid.  Upon gazing into the room, saliva bites at your teeth, it's been a long day and you are very thirsty", true);
      Room Bedroom = new Room("Your Bedroom", "You were so sleepy, this was the first night you've gotten any rest as you've fervently spent every night studying C# as if it was ancient hyroglyphics with the universes answers inside.  You situp petting your dog and only social contact in life Nibbles as he lie passed out as if he actually worked or did anything but beg for your food then musk you in his comforted slumber, you reach to your inn table, drinking from your quarter mountain dew......cigarette butt.  Mother has been smoking next to your bed as she watched you sleep yet again against your fairer wishes.  You look around.....this isn't home?", false);
      Room Haven = new Room("Safe Haven", "You walk into a room, you see a window that sheens of moving water, through it you can see blue sky, your dog Nibbles.  It's HOME!!  You've made it HOME!! Mother was right you never should have left her sight, Mother was always right", false);
      Room KeyBank = new Room("The Key Bank", "You enter a room, there's keys everywhere, in the middle of the room you see something, a bottle with Nibbles picture on it.  You have a deep sense of trust, IT'S MOUNTAIN DEW!!  Nibbles must know i'm lost and he's helping", false);
      Room Hallway = new Room("The Hallway", "You walk into a dark musty hallway, it breaks into 4 directions: Straight, Left, Right and UP, 'how did I get here? you wondered, this isn't Kansas'", false);

      Item Dew = new Item("Mountain Dew!", "Savagely you tip the can putting away 12 ounces of sugary wonder in no time at all");

      Bedroom.Inventory.Add(Dew);

      TaxationStation.Exits.Add(Hallway.Name.ToLower(), Hallway);
      HeavensGate.Exits.Add(Hallway.Name.ToLower(), Hallway);
      Bedroom.Exits.Add(Hallway.Name.ToLower(), Hallway);
      KeyBank.Exits.Add(Haven.Name.ToLower(), Haven);
      Hallway.Exits.Add(TaxationStation.Name, HeavensGate.Name, Bedroom.Name, KeyBank.Name);
      //If current is ever Haven invoke EndGame

      System.Console.WriteLine("Please enter your Name");
      string userInput = Console.ReadLine();
      MyPlayer = new Player(userInput);
      CurrentRooms = Bedroom;
      StartGame();
      GameSetup();
    }
    public void StartGame()
    {
      System.Console.WriteLine($"Welcome {Name}, thank you for playing Treasure Hunter");

    }
    public void ChooseMove()
    {
      System.Console.WriteLine("You have stepped outside your bedroom and you are in the Hallway. What will you do? Press 'F' to go Forward, Press 'L' to go Left, Press 'R' to go Right, Press 'U' to go Up ");
      bool PlayerChoice = true;
      switch (Console.ReadLine().ToLower())
      {
        case "F":
          MyPlayer
      }

    }
    public void EndGame()
    {

    }
  }
}

