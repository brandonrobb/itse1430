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
        static void Main ( string[] args )
        {
            introPrompt();

            bool done = false;

            //Handle quit isnt working
            done = EnterShip("Would you like to board the ship (Y/N)? ");




            while (!done)
            {


                //need to implement controls and mapping

                Lv1PromptA();

                runGameLv1();

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
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nGlad you survived!\n");
            Console.ReadLine();
            Console.Clear();
        }   //end main




        static void runGameLv1 ()
        {

        }

        static void runGameLv2 ()
        {

        }

        static void runGameLv3 ()
        {

        }

        static void runGameLv4 ()
        {

        }

        static void runGameLv5 ()
        {

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
                   "materials to patch the holes in the ship located in 3 different rooms. \n " +
                   "Then after, you will be able to board the auxilary life boat to escape! ");

            Console.ReadLine();
            Console.Clear();
        }

        private static bool myHandleQuit ()
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