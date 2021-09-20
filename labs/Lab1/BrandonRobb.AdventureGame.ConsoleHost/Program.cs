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

        static void Main(string[] args)
        {

            /* ConsoleKeyInfo c = new ConsoleKeyInfo();

             do
             {
                 Console.WriteLine("\nPress a key to display; " + "press the 'z' to quit.");
                 while (Console.KeyAvailable == false)
                     Thread.Sleep(50);
                 c = Console.ReadKey();
                 Console.WriteLine("You pressed the '{0}' key.", c.Key);
             } while (c.Key != ConsoleKey.Z);
             Console.ReadLine();

             

                    char roomA ;
                switch (_Key.Key)
            {
                case ConsoleKey.RightArrow = 39;
                    Console.Writeline("Right Arrow");
                break;
                }
            



            
                string direction1 = Console.ReadKey();
            ConsoleKey direction = Char.Parse(direction1);

                //ConsoleKey
                // Console.WriteLine(direction);


            switch (direction)
                {
                    case ConsoleKey.RightArrow:
                    Console.WriteLine("right arrow");
                    break;
                } ;
            */

            introPrompt();

            bool done = false;

            //Handle quit isnt working
            done = EnterShip("Would you like to try to escape the ship (Y/N)? ");




            while (!done)
            {


                //need to implement controls and mapping

                Lv1PromptA();

                runGameLv1(){
                    room8Lv1();
                };
                
                                                 
                
                Lv1PromptB();

                Lv2PromptA();

                runGameLv2();

                Lv2PromptB();

                Lv3PromptA();

                runGameLv3();

                Lv3PromptB();

                Lv4PromptA();

                runGameLv4();

                Lv4PromptB();

                Lv5PromptA();

                runGameLv5();

                Lv5PromptB();

                done = HandleQuit("Are you sure you want to quit (Y/N)? ");

                /*switch ()
                {
                 * case 'Q':
                {
                    done = HandleQuit();
                    break;
                };
                case 'Y': EnterGame(); break;
                default: DisplayError("Unknown option"); break;
                */

            }
           
            Console.Clear();
            background();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\tSorry, you drowned on the ship...");
            Console.ReadLine();
            Console.Clear();
        }   //end main




        static void room8Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room5Lvl1(); break;
                    case "s":
                    case "S": Console.WriteLine("Cant move south"); break;
                    case "e":
                    case "E": room9Lvl1(); break; //Later..Console.Write("Room 9 is locked, find key to unlock");
                    case "w":
                    case "W": room7Lvl1(); break; //Later.. Console.Write("Room 7 is locked, find key to unlock");
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D": done(); break


                        //default:; 
                }

            } 
        }

        static void room5Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room2Lvl1(); break;//..room2Lvl2()
                    case "s":
                    case "S": room8Lvl1(); break;
                    case "e":
                    case "E": room6Lvl1(); break; 
                    case "w":
                    case "W": room4Lvl1(); break; 
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room2Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": Console.WriteLine("Cant move North"); break;
                    case "s":
                    case "S": room5Lvl1(); break;
                    case "e":
                    case "E": room3Lvl1(); break; //Later..Console.Write("Room 3 is locked, find key to unlock");
                    case "w":
                    case "W": room1Lvl1(); break; //Later.. Console.Write("Room 1 is locked, find key to unlock");
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room6Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room3Lvl1(); break;//Later...Cant Access room 3 locked
                    case "s":
                    case "S": room9Lvl1(); break;
                    case "e":
                    case "E": Console.WriteLine("Cant move East"); break; 
                    case "w":
                    case "W": room5Lvl1(); break; //Later.. Console.Write("Room 1 is locked, find key to unlock");
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }


        static void room9Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room6Lvl1(); break;
                    case "s":
                    case "S": Console.WriteLine("Cant move South"); break;
                    case "e":
                    case "E": Console.WriteLine("Cant move East"); break;
                    case "w":
                    case "W": room8Lvl1(); break; 
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room7Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room4Lvl1(); break;
                    case "s":
                    case "S": Console.WriteLine("Cant move South"); break;
                    case "e":
                    case "E": room8Lvl1(); break;
                    case "w":
                    case "W": Console.WriteLine("Cant move West"); break;
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room4Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": room1Lvl1(); break;
                    case "s":
                    case "S": room7Lvl1(); break;
                    case "e":
                    case "E": room5Lvl1(); break;
                    case "w":
                    case "W": Console.WriteLine("Cant move West"); break;
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room1Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": Console.WriteLine("Cant move North"); break;
                    case "s":
                    case "S": room4Lvl1(); break;
                    case "e":
                    case "E": room2Lvl1(); break;
                    case "w":
                    case "W": Console.WriteLine("Cant move West"); break;
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }

        static void room3Lv1 ()
        {


            //char choice = GetInput();
            //{


            Console.WriteLine("What do you want to do?\n Walk (N)orth, (S)outh, (E)ast or (W)est? ");

            while (true)
            {
                string input = Console.ReadLine().Trim();
                //case insensitive
                switch (input.ToUpper())
                {   //No fallthrough must  
                    // must end in break or return

                    case "n":
                    case "N": Console.WriteLine("Cant move North"); break;
                    case "s":
                    case "S": room6Lvl1(); break;
                    case "e":
                    case "E": Console.WriteLine("Cant move East"); break;
                    case "w":
                    case "W": room2Lvl1(); break;
                    case "h":
                    case "H": help(); break;
                    case "d":
                    case "D":
                    done(); break


                        //default:; 
                }

            }
        }


        private static bool HandleQuit (string message)
        {
            //Display a confirmation
            if (ReadBoolean(message))
                return true;


            return false;


            //Shortcut of below code, preferred
            //return ReadBoolean("Are you sure you want to quit (Y/N)? ");
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







        static void introPrompt()
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
            private static bool myHandleQuit()
        {
            Console.WriteLine("Type YES To Begin or Type NO to Exit");

             

            string enterGame = Console.ReadLine();
            {
                if (enterGame == "YES")

                    return false;

                else if (enterGame == "yes")

                    return false;

                else
                    Console.WriteLine("Adios");
                return true;
            }



        }




        /* string enterGame = Console.ReadLine();
if enterGame = ("YES")
*/

        static void Lv1PromptA()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Find a round patch and a door key");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv1PromptB()
        {
            Console.WriteLine("Take the round patch and key to room 9 and patch the hole!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv2PromptA()
        {
            Console.WriteLine("Great Job!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv2PromptB()
        {
            Console.WriteLine("Take the square wood patch and key and find the next hole to patch");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hurry");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv3PromptA()
        {
            Console.WriteLine("You did it!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv3PromptB()
        {
            Console.WriteLine("Take the triangle weld patch and key and find the next hole to patch");
            Console.ReadLine();
            Console.Clear();
            
        }

        static void Lv4PromptA()
        {
            Console.WriteLine("Great Work!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv4PromptB()
        {
            Console.WriteLine("Take the key and water pump to the last room. \n" +
                " unlock the room and pump the water out  ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Move Quickly!!!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv5PromptA()
        {
            Console.WriteLine("The water is pumping out, aboard the auxilary boat to save your assets!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Lv5PromptB()
        {
            Console.WriteLine("You did it, you escaped from the sinking ship!");
            Console.ReadLine();
            Console.Clear();
        }



         /* if 

                System.Console.ReadKey(true).Key == ConsoleKey.UpArrow
                 Console.WriteLine("Cannot move Up");
                 System.Console.ReadKey(true).Key == ConsoleKey.DownArrow
                System.Console.ReadKey(true).Key == ConsoleKey.LeftArrow
                System.Console.ReadKey(true).Key == ConsoleKey.RightArrow
                   Console.WriteLine("Cannot move Up");
            

         if
            
                (System.Console.ReadKey(true).Key == ConsoleKey.UpArrow)
                 Console.WriteLine("Cannot move Up");

                else if

                    (System.Console.ReadKey(true).Key == ConsoleKey.DownArrow)
                 Console.WriteLine("Cannot move ");

            else if

                    (System.Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
                Console.WriteLine("Cannot move ");

            else if

                    (System.Console.ReadKey(true).Key == ConsoleKey.RightArrow)
                Console.WriteLine("Cannot move ");

            else
               Console.WriteLine("Unknown option");



                /*if (choice == 'Q' || choice == 'q')
                //done = HandleQuit();
                //if (choice == 'Q')
                //    done = HandleQuit();
                //else if (choice == 'A')
                //    AddMovie();
                //else if (choice == 'V')
                //    ViewMovie();
                //else if (choice == 'D')
                //    DeleteMovie();
                //else
                //    Console.WriteLine("Unknown option");
                switch (choice)
                {
                    case 'Q':
                    {
                        done = HandleQuit(); break;
                    };
                    case 'A': AddMovie(); break;
                    case 'V': ViewMovie(); break;
                    case 'D': DeleteMovie(); break;
                    default: DisplayError("Unknown Option"); break;
                };
            } while (!done);
                */

    }
}