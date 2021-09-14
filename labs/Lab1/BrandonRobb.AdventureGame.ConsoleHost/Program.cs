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
        static void Main (string[] args)
        {

            Console.WriteLine(" You have awoken from your long nights rest, suprisingly to find yourself stranded on a sinking cruise ship. " +
                "\nSearch the rooms of the ship to find materials to patch the holes in the ship located in 3 different rooms." +
                " \nThen after, you will be able to board the auxilary life boat to escape! \n");

            //Console.Clear();

            Console.WriteLine("Type YES To Begin or Type NO to Exit");


            string enterGame = Console.ReadLine();

            if (enterGame == "YES")
            {
                Console.WriteLine("OK");
            } 
            else
            {
                Console.WriteLine("Adios");
            }
        }
    }
}
