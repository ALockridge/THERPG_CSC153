using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THERPG_CSC153
{
    class Program
    {
        static void Main(string[] args)
        {
			bool exit = false;

			//Main menu

			while (exit == false)
			{

				Console.WriteLine("TODO - User prompt");
				Console.WriteLine("1. A User's Choice");
				Console.WriteLine("2. Exit");
				Console.Write("Enter a choice > ");
				string input = Console.ReadLine();

				if (input == "1")
				{
					//TODO
				}
				else if (input == "2")
				{
					exit = true;
				}
				else
				{
					Console.WriteLine("Not a choice!");
				}
			}

		}
    }
}
