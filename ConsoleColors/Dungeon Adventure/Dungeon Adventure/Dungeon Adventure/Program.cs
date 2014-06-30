using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, yn, adventure;
            Console.Title =" Mindscape Dungeon Adventure ";
            Console.WriteLine(" Welcome Adventurer ");
            Console.WriteLine(" What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine(" Would you like to go on an adventure " + name);
            Console.WriteLine(" Yes or No? ");
            yn = Console.ReadLine();
           yn = yn.ToUpper();
           if (yn == "YES")
           {
               Console.WriteLine(" Then let the adventure begin ");
               Console.WriteLine(" Do you want to go to the Forests, Mountains, Plains, Islands, Swamps? ");
               adventure = Console.ReadLine();
               adventure = adventure.ToUpper();

              string welcometo = " Welcome to the ";
              // Array mycolor = ["Green", "Red", "White", "Blue", "Black"];
              //int colorint = 0;
              // string thepowerof = " The Power of " + mycolor[] + "Infuses your body." ;
             // string[][]  thepowerof = new string  [" The Power of "],["Green", "Red", "White", "Blue", "Black"];
              string[][] thepowerof = new string[][]{
new string[]{" The Power of "},
new string[]{" Green ", " Red ", " White ", " Blue ", " Black "},
 new string[]{" mana infuses you. "}             
              };
string manasent =" mana infuses you. ";
string[] mycolor = {" Green ", "Red", "White", "Blue", " Black "};
               switch (adventure)
               {
                   case "FORESTS":
                      // colorint = 0;
                       Console.BackgroundColor = ConsoleColor.DarkGreen;
                       Console.ForegroundColor = ConsoleColor.White;
                       Console.WriteLine(welcometo +" Forests ");
                      Console.WriteLine(thepowerof[0][0] + mycolor[0]  + manasent);
                      
                      break;

                  case "MOUNTAINS":
                      Console.BackgroundColor = ConsoleColor.DarkRed;
                      Console.ForegroundColor = ConsoleColor.White;
                      Console.WriteLine( welcometo + " Mountains");
                      Console.WriteLine(thepowerof[0][0] + mycolor[1] + manasent);
                      
                      
                      break;
                   case "PLAINS":
                      Console.BackgroundColor = ConsoleColor.DarkYellow;
                      Console.ForegroundColor = ConsoleColor.White;
                      Console.WriteLine(welcometo + " Plains ");
                      //Console.WriteLine(thepowerof[0][0] + thepowerof[0][3] + manasent);
                      Console.WriteLine(thepowerof[0][0] + mycolor[2] + manasent);
                      
                      
                      break;
                  case "ISLANDS":
                       Console.BackgroundColor = ConsoleColor.DarkBlue;
                           Console.ForegroundColor = ConsoleColor.White;
                       Console.WriteLine(welcometo + " Islands ");
                       Console.WriteLine(thepowerof[0][0] + mycolor[3] + manasent);
                       
                       break;

                   case "SWAMPS":
                       Console.BackgroundColor = ConsoleColor.DarkGray;
                       Console.ForegroundColor = ConsoleColor.Black;
                       Console.WriteLine(welcometo + " Swamps ");
                       Console.WriteLine(thepowerof[0][0] + mycolor[4] + manasent);
                      break;

                   default:
                      Console.WriteLine(" I did not hear you correctly. Where did you want to go? ");
                      break;
               }


           }
           else
           {
               Console.WriteLine("Come again soon.");

               



           }

            Console.ReadKey();













        }
    }
}
