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
        static int currentX = 1;
        static int currentY = 2;
        const int MaximumX = 3;
        const int MaximumY = 3;


        static void Main ( string[] args )
        {
            introPrompt();

            bool done = false;
            done = EnterShip("Would you like to board the ship (Y/N)? ");
            Console.Clear();
            Console.WriteLine("Which direction would you like to walk? \n To walk Press Button \n(N) for North," +
                   " \n(S) for South,\n (E) for East or.. \n (W)for West? \n (H)for Help & (Q) to Quit ");
            //Console.Clear();
            while (!done)
            {
                
                string input = Console.ReadLine().Trim();

                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N":
                    moveFuction('N', currentX, currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H)for Help & (Q) to Quit ");
                    break;//Later...Cant Access room 3 locked

                    case "s":
                    case "S":
                    moveFuction('S', currentX, currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H)for Help & (Q) to Quit ");
                    break;

                    case "e":
                    case "E":
                    moveFuction('E', currentX, currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H)for Help & (Q) to Quit ");
                    break;

                    case "w":
                    case "W":
                    moveFuction('W', currentX, currentY);
                    FindRoomToDisplay();
                    Console.WriteLine("To walk press N,S,E or W" +
                    "\n Press (H)for Help & (Q) to Quit ");
                    break; //Later.. Console.Write("Room 1 is locked, find key to unlock");

                    case "h":
                    case "H": help();
                    break;
                    //case "i":
                    //case "I": FindRoomToDisplay(); break;//Inspect
                    case "q":
                    case "Q": done = HandleQuit("Are you sure you want to quit (Y/N)? ");
                    break;
                }

                



                //done = HandleQuit("Are you sure you want to quit (Y/N)? ");

            }
            //Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYou Drowned on the ship!\n");
            Console.ReadLine();
            Console.Clear();
        }   //end main

        static void help ()
        {
            Console.WriteLine("To walk press N,S,E or W \n  (N)orth, (S)outh, (E)ast or (W)est?\n" +
                "To Quit press Q");
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
            if (newX >= 0 && newX < MaximumX && newY >= 0 && newY < MaximumY)
            {
                currentX = newX;
                currentY = newY;
                Console.WriteLine("Current position: " + currentX+ " , " + currentY);
                
            } else Console.WriteLine("Room doesnt exist, try again!");
        }

        /// <summary>
        /// ////////////////////////////////////Need Helpppppppppppppppppppp Below With Display Function
        /// </summary>
        //{

        //}

        static void FindRoomToDisplay ( )
       {
           int roomNumber = currentX + (MaximumX * (currentY - 1));

           switch (roomNumber)
           {
                case '1': Console.WriteLine("1"); break;
                case '2': Console.WriteLine("2"); break;
                case '3': Console.WriteLine("3"); break;
                case '4': Console.WriteLine("4"); break;
                case '5': Console.WriteLine("5"); break;
                case '6': Console.WriteLine("6"); break;
                case '7': Console.WriteLine("7"); break;
                case '8': Console.WriteLine("8"); break;
                case '9': Console.WriteLine("9"); break;

                
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

        /* string enterGame = Console.ReadLine();
if enterGame = ("YES")
*/

        static void Lv1PromptA ()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Find a round patch and a door key");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv1PromptB ()
        {
            Console.WriteLine("Take the round patch and key to room 9 and patch the hole!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv2PromptA ()
        {
            Console.WriteLine("Great Job!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv2PromptB ()
        {
            Console.WriteLine("Take the square wood patch and key and find the next hole to patch");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv3PromptA ()
        {
            Console.WriteLine("You did it!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv3PromptB ()
        {
            Console.WriteLine("Take the triangle weld patch and key and find the next hole to patch");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv4PromptA ()
        {
            Console.WriteLine("Great Work!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv4PromptB ()
        {
            Console.WriteLine("Take the key and water pump to the last room. \n" +
                " unlock the room and pump the water out  ");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv5PromptA ()
        {
            Console.WriteLine("The water is pumping out, aboard the auxilary boat to save your assets!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv5PromptB ()
        {
            Console.WriteLine("You did it, you escaped from the sinking ship!");
            Console.ReadLine();
            Console.Clear();
        }



    }
}