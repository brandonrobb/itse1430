/*
 * file header
 * Brandon Robb
 * ITSE 1430 Fall 2021
 */

using System;

namespace BrandonRobb.AdventureGame.ConsoleHost
{
    class Program
    {
        static int s_currentX = 1;
        static int s_currentY = 2;
        const int s_maximumX = 3;
        const int s_maximumY = 3;


        static void Main ( string[] args )
        {
            introPrompt();

            bool done = false;
            done = EnterShip("Would you like to try to escape the sinking ship (Y/N)? ");
            Console.Clear();
            FindRoomToDisplay();
            Console.WriteLine("Which direction would you like to walk? \n To walk Press Button \n (N) for North," +
                   " \n (S) for South,\n (E) for East or.. \n (W)for West? \n (H)for Help & (Q) to Quit ");

            while (!done)
            {

                string input = Console.ReadLine().Trim();

                switch (input.ToUpper())
                {
                    case "n":
                    case "N":
                    Console.Clear();
                    moveFuction('N', s_currentX, s_currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H) for Help \n Press (I) to Inspect Room \n & (Q) to Quit  ");
                    break;

                    case "s":
                    case "S":
                    Console.Clear();
                    moveFuction('S', s_currentX, s_currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H) for Help \n Press (I) to Inspect Room \n & (Q) to Quit  ");
                    break;

                    case "e":
                    case "E":
                    Console.Clear();
                    moveFuction('E', s_currentX, s_currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H) for Help \n Press (I) to Inspect Room \n & (Q) to Quit ");
                    break;

                    case "w":
                    case "W":
                    Console.Clear();
                    moveFuction('W', s_currentX, s_currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H) for Help \n Press (I) to Inspect Room \n & (Q) to Quit  ");
                    break;

                    case "i":
                    case "I":
                    Console.Clear();
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H) for Help and \n (Q) to Quit  ");
                    break;

                    case "h":
                    case "H":
                    Console.Clear();
                    help();
                    break;

                    case "q":
                    case "Q":
                    Console.Clear();
                    done = HandleQuit("Are you sure you want to quit (Y/N)? ");
                    break;

                    default: Console.WriteLine("Invalid Key"); help(); break;
                }
            }

            Console.Clear();
            Console.WriteLine("\nYou Drowned on the ship!\n");
            Console.ReadLine();
            Console.Clear();
        }

        static void help ()
        {
            Console.WriteLine("To walk press (N),(S),(E) or (W).. \n  (N)orth, (S)outh, (E)ast or (W)est?\n" +
                " To Quit press (Q) \n To get room description press (I)");
        }

        static void moveFuction ( char direction, int x, int y )
        {
            int newX = x, newY = y;
            switch (direction)
            {
                case 'N': newY -= 1; break;
                case 'S': newY += 1; break;
                case 'W': newX -= 1; break;
                case 'E': newX += 1; break;
            }
            if (newX > -1 && newX < s_maximumX && newY > -1 && newY < s_maximumY)
            {
                s_currentX = newX;
                s_currentY = newY;
                Console.WriteLine("Current position: " + s_currentY + "N , " + s_currentX + "E");

            } else Console.WriteLine("Room you are trying to enter doesnt exist, \n try again!");
        }


        static void FindRoomToDisplay ()
        {
            int roomNumber = s_currentX + (s_maximumX * (s_currentY));

            switch (roomNumber)
            {
                case 0: Console.WriteLine("\nYou are at the top of the ship, \n here is a small boat filled of water\n"); break;
                case 1: Console.WriteLine("\nThis room has a round object that looks like \n it is made to patch a hole and a key\n"); break;
                case 2: Console.WriteLine("\nThere is a triangle hole in the wall leaking water \n into the ship, a water pump and a key\n"); break;
                case 3: Console.WriteLine("\nThis is a dark empty room with 3 doors\n"); break;
                case 4: Console.WriteLine("\nYou have entered into wet empty room \n with a table and 4 doors\n"); break;
                case 5: Console.WriteLine("\nThis is a dim humid room with 3 doors\n"); break;
                case 6: Console.WriteLine("\nThere is a square hole in the wall leaking water \n into the ship, a triangle patch and a key\n"); break;
                case 7: Console.WriteLine("\nYou are in a dark empty room with 3 doors\n"); break;
                case 8: Console.WriteLine("\nYou have entered into a room and you notice \n a round hole in the wall, a square patch and a key\n"); break;
            };
        }

        private static bool HandleQuit ( string message )
        {
            //Display a confirmation
            if (ReadBoolean(message))
                return true;
            return false;

        }


        private static bool EnterShip ( string message )
        {
            //Display a confirmation
            if (ReadBoolean(message))
                return false;

            return true;

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
                   "materials to patch the holes in the ship walls,\n located in 3 of the 9 different rooms. " +
                   "Then after, you will be able to board \n the auxilary life boat to escape!\n" +
                   " Press Enter ");

            Console.ReadLine();
            Console.Clear();
        }


    }
}