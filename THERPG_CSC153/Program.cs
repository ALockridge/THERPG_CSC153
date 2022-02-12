using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**

* 12/12/22

* CSC 153

* Aaingel Lockridge

* The RPG C# Edition

*/


namespace THERPG_CSC153
{
    class Program
    {
        static void Main(string[] args)
        {
			bool exit = false;
			int HP = 24;
			int ATK = 4;
			string[] rooms = { "in a grassy field", "at the Cave entrance", "in the inner Cave", "at the outer Cave", "at the Cave's exit" };
			string[] roomNames = { "field", "cave entrance", "inner Cave", "outer Cave", "Cave exit" };

			//MOB ASSIGNMENTS
			//MOB STATS, CORRESPOND TO POSITION IN LIST
			int[] mobHP = { 18, 64, 84, 220, 100, 300 };
			int[] mobATK = { 2, 12, 18, 30, 16, 6 };

			List<string> mobs = new List<string> { "Blob", "Skeleton", "Thief", "Robot", "Fire Monster", "Water Monster" };
			
			//POTIONS, TREASURES, WEAPONS, ITEMS
			string[] potions = { "HPotion", "ATonic" };
			string[] treasures = { "GOLD", "SILVER", "COPPER" };
			string[] weapons = { "Stick", "Dull Knife", "Sharp Knife", "Crowbar", "Shortsword" };
			List<string> items = new List<string> { "Key", "Stone", "Cloth", "Metal" };

			int currentRoom = 0;
			Console.BackgroundColor = ConsoleColor.Black;
			//Main menu

			while (exit == false)
			{

				Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("you are " + rooms[currentRoom]);
                Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("╦═══");
				Console.WriteLine("╠1] DISPLAY ROOMS");
				Console.WriteLine("╠2] DISPLAY WEAPONS");
				Console.WriteLine("╠3] DISPLAY POTIONS");
				Console.WriteLine("╠4] DISPLAY TREASURE");
				Console.WriteLine("╠5] DISPLAY ITEMS");
				Console.WriteLine("╠6] DISPLAY MOBS");
				Console.WriteLine("╠7] EXIT");
				Console.WriteLine("╩═══");
				Console.Write("O>> ");
				Console.ForegroundColor = ConsoleColor.Blue;
				string input = Console.ReadLine();

				switch (input.ToLower())
				{
					case "1":
					case "rooms":
                        Console.WriteLine("ROOMS:"); 
						foreach (string value in roomNames)			//DISPLAYS roomNames, NOT rooms,
																	//ROOMNAMES IS NOT TO BE USED ELSEWHERE, ONLY ROOMS
						{
							Console.ForegroundColor = ConsoleColor.DarkGray;
							Console.WriteLine(value);
                        }
						//TRY TO HIGHLIGHT CURRENT ROOM
						break;
					case "2":
					case "weapons":
						Console.WriteLine("WEAPONS:");
						foreach (string value in weapons)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(value);
						}
						break;
					case "3":
					case "potions":
						Console.WriteLine("POTIONS:");
						foreach (string value in potions)
						{
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.WriteLine(value);
						}
						break;
					case "4":
					case "treasure":
						Console.WriteLine("TREASURES:");
						foreach (string value in treasures)
						{
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							Console.WriteLine(value);
						}
						break;
					case "5":
					case "items":
						Console.WriteLine("ITEMS:");
						foreach (string value in items)
						{
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
							Console.WriteLine(value);
						}
						break;
					case "6":
					case "mobs":
						Console.WriteLine("MOBS:");
						foreach (string value in mobs)
						{
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine(value);
						}
						break;

					//DIRECTIONAL MOVEMENT
					case "n":
						if(currentRoom != 4)
                        {
							currentRoom++;
                        }
						break;
                    case "s":
						if (currentRoom > 0)
						{
							currentRoom--;
						} else if (currentRoom == 0) {
							Console.ForegroundColor = ConsoleColor.Cyan;
							Console.WriteLine("YOU FOUND THE SUPER SECRET TOO-FAR-SOUTH ROOM!!!!!!!!!!!!!!");
							System.Threading.Thread.Sleep(500);
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("just kidding. you ran into the wall and died.");
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write("type \"R\" to restart. >");
							string pressed = Console.ReadLine();
 								if (pressed == "r")
							{
								exit = true;
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("that wasn't \"R\", but ok");

							}
						}
					break;
					case "7":
					case "exit":
						exit = true;
						break;
					default:
						// code block
						break;
				}
			}

		}
    }
}
