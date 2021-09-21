/*
 * file header
 * Brandon Robb
 * ITSE 1430 Fall 2021
 */

using System;
using System.Threading;

namespace BrandonRobb.AdventureGame.ConsoleHost

{
    class Program
    {
        static int currentX;
        static int currentY;
        const int MaximumX = 3;
        static void Main ( string[] args )
        {

            introPrompt();

            bool done = false;

            //Handle quit isnt working
            done = !ReadBoolean("Would you like to try to escape the ship (Y/N)? ");
            currentX = 2;
            currentY = 3;




            while (!done)
            {


                //need to implement controls and mapping
                FindRoomToDisplay();
                Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");
                string input = Console.ReadLine().Trim();
                
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": MoveNorth(); break;//Later...Cant Access room 3 locked
                    case "s":
                    case "S": MoveSouth(); break;
                    case "e":
                    case "E": MoveEast(); break;
                    case "w":
                    case "W": MoveWest(); break; //Later.. Console.Write("Room 1 is locked, find key to unlock");
                    case "h":
                    case "H": help(); break;
                    case "i":
                    case "I": FindRoomToDisplay(); break;//Inspect
                    case "d":
                    case "D": done = HandleQuit("Are you sure you want to quit (Y/N)? "); break;
                }


            }

            Console.Clear();
            background();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\tSorry, you drowned on the ship...");
            Console.ReadLine();
            Console.Clear();
        }   //end main


      

}
    static void FindRoomToDisplay ()
    {
        int roomNumber = currentX + (MaximumX * (currentY - 1));

        switch (roomNumber)
        {
            case 1: rm1Dsrcpt(); break;
            case 2: rm2Dsrcpt(); break;
            case 3: rm3Dsrcpt(); break;
            case 4: rm4Dsrcpt(); break;
            case 5: rm5Dsrcpt(); break;
            case 6: rm6Dsrcpt(); break;
            case 7: rm7Dsrcpt(); break;
            case 8: rm8Dsrcpt(); break;
            case 9: rm9Dsrcpt(); break;
        }


        private static bool HandleQuit ( string message )
        {
            //Display a confirmation
            if (ReadBoolean(message))
                return true;


            return false;


            //Shortcut of below code, preferred
            //return ReadBoolean("Are you sure you want to quit (Y/N)? ");
        }
        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);


            do
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                    return true;
                else if (input.Key == ConsoleKey.N)
                    return false;
            } while (true);


            //Not needed anymore
            //return false;
        }

        static void introPrompt ()
        {
            Console.WriteLine(" You have awoken from your long nights rest, suprisingly to find yourself stranded " +
                   " on a sinking cruise ship. \n Search the rooms of the ship to find " +
                   "materials to patch the holes in the ship located in 3 different rooms. \n " +
                   "Then after, you will be able to board the auxilary life boat to escape! ");

            Console.ReadLine();
            Console.Clear();
        }

        static void background ()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            //Console.ResetColor();
            //Console.ReadLine();
        }



           else
            Console.WriteLine("Unknown option");





    }
}



/*static void MoveNorth ()
//Assume current position is x, y
{
    int newX = x, newY = y;
    newY -= 1;
}
static void MoveSouth ()
//Assume current position is x, y
{
    int newX = x, newY = y;
    newY += 1;
}
static void MoveEast ()
//Assume current position is x, y
{
    int newX = x, newY = y;
    newY -= 1;
}
static void MoveWest ()
//Assume current position is x, y
{
    int newX = x, newY = y;
    newY += 1;
}


MoveSouth() newY += 1;
MoveEast()newX -= 1;
MoveWest()  newX += 1;
//Assume current position is x, y
int newX = x, newY = y;

 static void FindRoomToDisplay ()
    {
        int roomNumber = currentX + (MaximumX * (currentY - 1));

        switch (roomNumber)
        {
            case 1: rm1Dsrcpt("This room has a small boat inside but it is filled with water"); break;
            case 2: rm2Dsrcpt("There is a key and a round object that could be used for a patch"); break;
            case 3: rm3Dsrcpt("This room has a water pump, a key and a triangle hole in the wall pouring water into the room "); break;
            case 4: rm4Dsrcpt("This is a empty room with 3 doors"); break;
            case 5: rm5Dsrcpt("This is a empty room with 4 doors to walk through"); break;
            case 6: rm6Dsrcpt("Nothing in here, 3 doors you can choose to go through"); break;
            case 7: rm7Dsrcpt("There is a square hole in the wall leaking water, a triangle patch and a key"); break;
            case 8: rm8Dsrcpt("Initial starting point.. with 3 doors and an empty table"); break;
            case 9: rm9Dsrcpt("There is a round hole leaking water, a square patch and a key"); break;
        }