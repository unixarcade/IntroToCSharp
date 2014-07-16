using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
// Luminosity
// http://luminosity.livejournal.com


namespace Dungeon_Adventure
{
    //public  class myform 
    //{
    //    Form f = new Form();
    //   private string myformtext {get; set;}
    //    private string myformtextname() {
    //         mytext = "  Empty Dungeon Adventure  ";
    //        return mytext;
    //}
        
    //    private string mytextname{get; set;}
    //    private string myformtextname(){

           
    //    }

    //    f.Text = 
    //    f.Name = "Empty Dungeon Adventure";
    //    Label nameLabel = new Label();
    //    nameLabel.AutoSize = true;
    //    nameLabel.Text = "Empty Dungeon Adventure";
    //    nameLabel.Top = 100;
    //    nameLabel.Left = 80;
    //    f.Controls.Add(nameLabel);
    //    f.ShowDialog();

    //}

    class Program
    {

        static void myexit()
        {
            Environment.Exit(0);
        }

        static string myYesNo()
        {
            Console.WriteLine(" Yes or No? ");
           string  yn = Console.ReadLine();
           if (yn == "y" || yn == "ye")
           {
               yn = "YES";
           }
           else
           {
               yn = "NO";
           }
            yn = yn.ToUpper();
            return yn;
        }
        static void Main(string[] args)
        {
            // Form Source Code
           
          // new myform();
            // This Code Should really be in a Class
           //public static myform
           // {
           // Form f = new Form();

           // f.Text = "  Empty Dungeon Adventure  ";
           // f.Name = "Empty Dungeon Adventure";
           // Label nameLabel = new Label();
           // nameLabel.AutoSize = true;
           // nameLabel.Text = "Empty Dungeon Adventure";
           // nameLabel.Top = 100;
           // nameLabel.Left = 80;
           // f.Controls.Add(nameLabel);
           // f.ShowDialog();

           // }



            // End of Form Code




            string name, adventure;
            int managoal;
            managoal = 0;
            Console.Title =" Mindscape Dungeon Adventure ";
            Console.WriteLine(" Welcome Adventurer ");
            Console.WriteLine(" What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine(" Would you like to go on an adventure " + name);
            //Console.WriteLine(" Yes or No? ");
            //yn = Console.ReadLine();
           //yn = yn.ToUpper();
            string mycode;
            mycode = myYesNo();
           
            if (mycode == "YES")
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
                       
                       
                       Console.WriteLine("In the swamp you see a bat do you kill it with your magic yes or no?");
                     // yn = Console.ReadLine();
                    // yn = yn.ToUpper();
                     mycode = myYesNo();
                    if (mycode =="YES"){
                           managoal++;
                           Console.Write(" You have grown in Dark Power " + " Mana Force: " + managoal);
                       
                      
                       
                       
                       }
                       else
                       {
                           Console.WriteLine("You may never grow strong enough to Wield the Dark Power");
                       }
                       
                       if (managoal == 10)
                       {
                           Console.WriteLine("You are now the avatar of Black Mana");
                       }
                       
                       
                       
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
